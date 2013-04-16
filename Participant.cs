
namespace FedACH
{
    /// <summary>
    /// A Fed ACH Participant
    /// </summary>
    public class Participant
    {
        /// <summary>
        /// Gets or sets the routing number.
        /// Length: 9, Position: 1-9
        /// </summary>
        /// <value>
        /// The routing number.
        /// </value>
        public string RoutingNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the office code, Main office or branch O=main B=branch
        /// Length: 1, Position:10
        /// </summary>
        /// <value>
        /// The office code.
        /// </value>
        public string OfficeCode
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the Servicing Fed's main office routing number.
        /// Length: 9, Position:11-19
        /// </summary>
        /// <value>
        /// The servicing FRB number.
        /// </value>
        public string ServicingFRBNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the record type code.
        /// Length: 1, Position:20
        /// </summary>
        /// <remarks>
        /// The code indicating the ABA number to be used to route or send ACH items to the RFI
        /// 0 = Institution is a Federal Reserve Bank
        /// 1 = Send items to customer routing number
        /// 2 = Send items to customer using new routing number field
        /// </remarks>
        /// <value>
        /// The record type code.
        /// </value>
        public string RecordTypeCode
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the Date of last change to CRF information (MMDDYY).
        /// Length: 6, Position:21-26
        /// </summary>
        /// <value>
        /// The Date of last change to CRF information (MMDDYY).
        /// </value>
        public System.DateTime ChangeDate
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the Institution's new routing number resulting from a merger or renumber
        /// Length: 9, Position:27-35
        /// </summary>
        /// <value>
        /// The new routing number.
        /// </value>
        public string NewRoutingNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the Commonly used abbreviated name.
        /// Length: 36, Position:36-71
        /// </summary>
        /// <value>
        /// The name of the customer.
        /// </value>
        public string CustomerName
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the Delivery address.
        /// Length: 36, Position:72-107
        /// </summary>
        /// <value>The Delivery address.</value>
        public string Address
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the City name in the delivery address.
        /// Length: 20, Position: 108-127
        /// </summary>
        /// <value>
        /// The City name in the delivery address.
        /// </value>
        public string City
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the State code of the state in the delivery address.
        /// Length: 2, Position:128-129
        /// </summary>
        /// <value>
        /// The State code of the state in the delivery address..
        /// </value>
        public string StateCode
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the zip code in the delivery address.
        /// Length: 5, Position:130-134
        /// </summary>
        /// <value>
        /// The zipcode.
        /// </value>
        public string Zipcode
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the Zip code extension in the delivery address.
        /// Length: 4, Position:135-138
        /// </summary>
        /// <value>
        /// The zipcode extension.
        /// </value>
        public string ZipcodeExtension
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the Area code of the CRF contact telephone number.
        /// Length: 3, Position:139-141
        /// </summary>
        /// <value>
        /// The Area code of the CRF contact telephone number.
        /// </value>
        public string TelephoneAreaCode
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the Prefix of the CRF contact telephone number.
        /// Length: 3, Position:142-144
        /// </summary>
        /// <value>
        /// The Prefix of the CRF contact telephone number.
        /// </value>
        public string TelephonePrefixNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the Suffix of the CRF contact telephone number.
        /// Length: 4, Position:145-148
        /// </summary>
        /// <value>
        /// The Suffix of the CRF contact telephone number.
        /// </value>
        public string TelephoneSuffixNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the institution status Code is based on the customers receiver code 1=Receives Gov/Comm
        /// Length: 1, Position:149
        /// </summary>
        /// <value>
        /// The institution status code.
        /// </value>
        public string InstitutionStatusCode
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the data view code. 1=Current view
        /// Length: 1, Position:150
        /// </summary>
        /// <value>
        /// The data view code.
        /// </value>
        public string DataViewCode
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the filler Spaces.
        /// Length: 5, Position:151-155
        /// </summary>
        /// <value>
        /// The filler Spaces.
        /// </value>
        public string Filler
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}