using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions;

namespace Infrastructure.Services;

public class EmailService : IEmailService
{
    public async Task SendWelcomeEmailAsync(string to)
    {
        Console.WriteLine($"Sending welcome email to: {to}");
        await Task.CompletedTask;
    }
}

