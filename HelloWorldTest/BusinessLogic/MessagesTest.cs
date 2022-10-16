using HelloWorldLibrary.BusiessLogic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTest.BusinessLogic;

public class MessagesTest
{
    [Fact]
    public void Greeting_InEnlish()
    {
        ILogger<Messages> logger = new NullLogger<Messages>();

        Messages messages = new(logger);

        string expected = "Hello World";
        string actual = messages.Greeting("en");

        Assert.Equal(expected, actual);


    }


    [Fact]
    public void Greeting_InSpanish()
    {
        ILogger<Messages> logger = new NullLogger<Messages>();

        Messages messages = new(logger);

        string expected = "Hola Mundo";
        string actual = messages.Greeting("es");

        Assert.Equal(expected, actual);


    }

    [Fact]
    public void Greeting_Invalid()
    {
        ILogger<Messages> logger = new NullLogger<Messages>();

        Messages messages = new(logger);

        Assert.Throws<InvalidOperationException>( () => messages.Greeting("fr"));


    }
}
