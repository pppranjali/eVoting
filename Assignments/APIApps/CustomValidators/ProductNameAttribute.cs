using System.ComponentModel.DataAnnotations;


namespace APIApps.CustomValidators
{
    public class ProductNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string str = "@#!";
            foreach(char c in str)
            {
                if(Convert.ToString(value).Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
