using System.Text.Json;
using ImagePlugin.Interfaces;
using ImagePlugin.Models;

namespace ImagePlugin.Services;

public class PluginLoader : IPluginLoader
{
    public async Task LoadPluginsAsync(PluginManager manager, string configPath)
    {
        var json = await  File.ReadAllTextAsync(configPath);
        var config = JsonSerializer.Deserialize<List<PluginConfig>>(json);
        foreach (var pluginConfig in config)
        {
            manager.RegisterPlugin(Activator.CreateInstance(Type.GetType(pluginConfig.Type)) as IPlugin);
        }
    }
}