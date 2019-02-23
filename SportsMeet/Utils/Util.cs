using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace SportsMeet
{
    class Util
    {
        public enum SexEnum : byte
        {
            NOT_KNOWN,
            MALE,
            FEMALE,
            NOT_APPLICABLE
        };

        public static SexEnum SexStringToEnum(String sex)
        {
            SexEnum sexEnum = SexEnum.NOT_APPLICABLE;
            if (sex == "Male")
            {
                sexEnum = SexEnum.MALE;
            }
            else if (sex == "Female")
            {
                sexEnum = SexEnum.FEMALE;
            }
            else if (sex == "not known")
            {
                sexEnum = SexEnum.NOT_KNOWN;
            }
            else if (sex == "")
            {
                sexEnum = SexEnum.NOT_KNOWN;
            }

            return sexEnum;
        }
    }
}
