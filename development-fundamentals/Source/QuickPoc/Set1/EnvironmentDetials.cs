﻿using QuickPoc.Interfaces;

namespace QuickPoc.Set1;

internal class EnvironmentDetials : IDemoProgram
{

    public void Run()
    {
        // See https://aka.ms/new-console-template for more information
        WriteLine(Environment.CurrentDirectory);
        WriteLine(Environment.OSVersion.VersionString);
    }

}
