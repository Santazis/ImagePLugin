using ImagePlugin.Models;
using ImagePlugin.Models.Parameters;
using ImagePlugin.Services;

var pluginManager = new PluginManager();
var pluginLoader = new PluginLoader();
var path = "E:\\Rider\\ImagePlugin\\Service\\plugins.json";
await pluginLoader.LoadPluginsAsync(pluginManager,path);
var images = new List<ImageData>();
for (int i = 0; i < 10; i++)
{
    images.Add(new ImageData(new byte[0], new List<EffectParameters>
    {
        new EffectParameters("Blur",new BlurParameters(25)),
        new EffectParameters("Resize",new ResizeParameters(800,400)),
    }));  
}

var tasks = images.SelectMany(image =>
    image.Effects.Select(effect =>
    {
        var plugin = pluginManager.GetPlugin(effect.Name);
        if (plugin == null)
        {
            Console.WriteLine($"Plugin {effect.Name} not found");
            return Task.CompletedTask;
        }
        return plugin.Process(image, effect.Parameters);
    })
);
await Task.WhenAll(tasks);