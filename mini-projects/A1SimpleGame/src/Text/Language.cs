﻿namespace A1SimpleGame.Src.Text;

public abstract partial class Language
{
    public string Welcome { get; protected set; } = "";

    public string ChooseYourName { get; protected set; } = "";

    public string DefaultName { get; protected set; } = "";

    public string DefaultRoomName { get; protected set; } = "";

    public string DefaultRoomDescription { get; protected set; } = "";

    public string ActionError { get; protected set; } = "";
}