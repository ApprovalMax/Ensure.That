using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsureThat;
using Newtonsoft.Json.Linq;
using Xunit;
using FluentAssertions;

namespace UnitTests
{
    public class EnsureCallerArgumentTest
    {
        [Fact]
        public void ArgumentNullException_Correctly_Captures_Null_Objects_Name_For_EnsureArgIsNotNull()
        {
            var nullObject = default(object);
            Action act = () => EnsureArg.IsNotNull(nullObject);
            act.Should().Throw<ArgumentNullException>().WithParameterName(nameof(nullObject));
        }
    }
}
