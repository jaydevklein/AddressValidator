using System;
using System.Windows.Forms;
using SmartyStreets;
using SmartyStreets.USStreetApi;

namespace AddressValidator
{
    class AddressTester
    {

        /*
         * Implementes SmartyStreets API to validate a USPS address
        */

        public AddressTester()
        {

        }

        public int validate_RequiredFields(string Street, string City, string State, string Zip, out string ValidationMessage)
        {
            /*
             * Return codes:
             * 0 All required fields are present
             * 1 at least one required field is empty
             */
            ValidationMessage = "";

            if (Street.Length == 0)
            {
                ValidationMessage += String.Format("Street address is a required field.\r\n");
            }

            if (City.Length == 0)
            {
                ValidationMessage += String.Format("City is a required field.\r\n");
            }

            if (State.Length == 0)
            {
                ValidationMessage += String.Format("State is a required field.\r\n");
            }

            if (Zip.Length == 0)
            {
                ValidationMessage += String.Format("Zip Code is a required field.\r\n");
            }

            if (Zip.Length < 5)
            {
                ValidationMessage += String.Format("Zip Code must be at least 5 digits.\r\n");
            }

            if (ValidationMessage.Length > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public int validate_USPSAddress(string Street, string Secondary, string City, string State, string Zip)
        {
            /*
             * Return codes:
             *  0 Good USPS address
             * -1 SmartyException exception
             * -2 IOException exception
             *  1 Address entered does not match USPS
             *  2 State returned does not match the Zip code entered
             *  3 Zip code returned does not match Zip code entered
             *  4 City entered does not match SmartyStreets database
             */
            var authId = "4d6ae97b-1625-654a-d23d-f141e4b24dd3";
            var authToken = "AjHklAjoKpJ67yj9r5uV";

            //For PRODUCTION store keys out side of code; environment variables or DB
            //var authId = Environment.GetEnvironmentVariable("SMARTY_AUTH_ID");
            //var authToken = Environment.GetEnvironmentVariable("SMARTY_AUTH_TOKEN");

            var client = new ClientBuilder(authId, authToken)
                .BuildUsStreetApiClient();

            // Documentation for input fields can be found at:
            // https://smartystreets.com/docs/us-street-api#input-fields

            var lookup = new Lookup
            {
                Street = Street,
                Secondary = Secondary,
                City = City,
                State = State,
                ZipCode = Zip,
                MaxCandidates = 1,
                MatchStrategy = Lookup.STRICT  // The API will ONLY return candidates that are valid USPS addresses.
            };

            try
            {
                client.Send(lookup);
            }
            // for PRODUCTION exception messages should be sent to a log that is monitored
            catch (SmartyException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return -1;
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
                return -2;
            }

            var candidates = lookup.Result;

            if (candidates.Count == 0)
            {
                Console.WriteLine("No candidates. This means the address is not valid.");
                return 1;
            }

            var firstCandidate = candidates[0];

            if (State != firstCandidate.Components.State)
            {
                return 2;  //State returned does not match the Zip code entered
            }

            if ((firstCandidate.Components.Plus4Code.Length > 0) && (Zip.Length == 9))
            {
                if (Zip != firstCandidate.Components.ZipCode + firstCandidate.Components.Plus4Code)
                {
                    return 3;  //Zip code entered does not match City/State
                }
            }
            else if (Zip != firstCandidate.Components.ZipCode)
            {
                return 3;  //Zip code entered does not match City/State
            }

            if (City.ToLower() != firstCandidate.Components.CityName.ToLower())
            {
                return 4;  //City entered does not match SmartyStreets database
            }

            Console.WriteLine("Address is valid. (There is at least one candidate)\n");
            Console.WriteLine("ZIP Code: " + firstCandidate.Components.ZipCode);
            Console.WriteLine("City: " + firstCandidate.Components.CityName);
            Console.WriteLine("State: " + firstCandidate.Components.State);

            return 0;
        }
    }
}
