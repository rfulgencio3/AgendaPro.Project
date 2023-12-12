﻿namespace AgendaPro.WebApp.Entities;

public class Template
{
    public string Name { get; set; }
    public Language Language { get; set; }
    public List<Component> Components { get; set; }
}
