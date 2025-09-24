using ImagePlugin.Services;

namespace ImagePlugin.Interfaces;

public interface IPluginLoader
{
    Task LoadPluginsAsync(PluginManager manager,string configPath);
}