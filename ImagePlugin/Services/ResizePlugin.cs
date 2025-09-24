using ImagePlugin.Interfaces;
using ImagePlugin.Models;
using ImagePlugin.Models.Parameters;

namespace ImagePlugin.Services;

public class ResizePlugin : Plugin<ResizeParameters>
{
    public ResizePlugin()
    {
        Name = "Resize";
    }

    public override Task Process(ImageData imageData, ResizeParameters parameters)
    {
        Console.WriteLine($"Applying resize,Width {parameters.Width},Height {parameters.Height}");
        return Task.CompletedTask;
    }
}