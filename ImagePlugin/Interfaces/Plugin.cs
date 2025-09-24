using ImagePlugin.Models;

namespace ImagePlugin.Interfaces;

public abstract class Plugin<TParameters> : IPlugin
{
    public string Name { get; set; }

    public abstract Task Process(ImageData imageData, TParameters parameters);
    async Task IPlugin.Process(ImageData imageData, object parameters)
    {
        await Process(imageData, (TParameters)parameters);
    }
}