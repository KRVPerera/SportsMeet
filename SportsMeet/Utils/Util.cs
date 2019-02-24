﻿using System;

namespace SportsMeet
{
    internal class Util
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

            if (String.IsNullOrEmpty(sex))
            {
                return sexEnum;
            }

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
            else
            {
                sexEnum = SexEnum.NOT_APPLICABLE;
            }

            return sexEnum;
        }

        public static bool ValidHumanSexString(String sex)
        {
            if (sex == "Male" || sex == "Female")
            {
                return true;
            }

            return false;
        }

        public static String SexEnumToSex(SexEnum sex)
        {
            if (sex == SexEnum.MALE)
            {
                return "Male";
            }
            else if (sex == SexEnum.FEMALE)
            {
                return "Female";
            }
            else if (sex == SexEnum.NOT_KNOWN)
            {
                return "not known";
            }
            else
            {
                return "NA";
            }
        }
    }
}