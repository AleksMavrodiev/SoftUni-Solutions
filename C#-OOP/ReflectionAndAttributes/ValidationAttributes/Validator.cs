using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objType = obj.GetType();
            PropertyInfo[] properties = objType.GetProperties().Where(x => x.CustomAttributes.Any(y => y.AttributeType.BaseType == typeof(MyValidationAttribute))).ToArray();

            foreach (PropertyInfo property in properties)
            {
                object propValue = property.GetValue(obj);

                foreach (CustomAttributeData customAttributeData in property.CustomAttributes)
                {
                    Type customAttributeType = customAttributeData.AttributeType;
                    object attributeInstance = property.GetCustomAttribute(customAttributeType);
                    MethodInfo validationMethod = customAttributeType
                       .GetMethods()
                       .First(m => m.Name == "IsValid");


                    bool result = (bool)validationMethod
                        .Invoke(attributeInstance, new object[] { propValue });
                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
