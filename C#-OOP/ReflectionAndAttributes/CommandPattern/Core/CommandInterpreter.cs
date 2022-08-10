using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] cmdArgs = args.Split();
            string commandName = cmdArgs[0];
            string[] parameters = cmdArgs.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();
            Type type = assembly.GetTypes().FirstOrDefault(x => x.Name == $"{commandName}Command" && x.GetInterfaces().Any(y => y == typeof(ICommand)));

            if (type == null)
            {
                throw new InvalidOperationException($"The command {commandName} is not valid");
            }

            object instance = Activator.CreateInstance(type);

            MethodInfo method = type.GetMethods().FirstOrDefault(x => x.Name == "Execute");
            string result = (string)method.Invoke(instance, new object[] { parameters });

            return result;
        }
    }
}
