namespace ImagePlugin.Interfaces;

public interface IPluginManager
{
    void RegisterPlugin(IPlugin plugin);
    IPlugin? GetPlugin(string name);
}