using ImagePlugin.Interfaces;

namespace ImagePlugin.Services;

public class PluginManager : IPluginManager
{
    public PluginManager()
    {
        _plugins = new Dictionary<string, IPlugin>();
    }
    private Dictionary<string, IPlugin> _plugins;
    public void RegisterPlugin(IPlugin plugin) => _plugins.Add(plugin.Name, plugin);
    public IPlugin GetPlugin(string name) => _plugins[name];
}