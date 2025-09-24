namespace ImagePlugin.Models;

public class EffectParameters
{
    public string Name { get; set; }
    public object Parameters { get; set; }

    public EffectParameters(string name,object parameters)
    {
        Name = name;
        Parameters = parameters;
    }
}