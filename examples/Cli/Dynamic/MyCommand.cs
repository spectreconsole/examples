using System;
using System.Threading;
using Spectre.Console;
using Spectre.Console.Cli;

namespace Dynamic;

public sealed class MyCommand : Command
{
    protected override int Execute(CommandContext context, CancellationToken cancellationToken)
    {
        if (!(context.Data is int data))
        {
            throw new InvalidOperationException("Command has no associated data.");

        }

        AnsiConsole.WriteLine("Value = {0}", data);
        return 0;
    }
}
