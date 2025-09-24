using ImagePlugin.Interfaces;
using ImagePlugin.Models;
using ImagePlugin.Models.Parameters;

namespace ImagePlugin.Services;

public class BlurPlugin : Plugin<BlurParameters>
{
    public BlurPlugin()
    {
        Name = "Blur";
    }

    public override Task Process(ImageData imageData,BlurParameters parameters)
    {
        Console.WriteLine($"Applying blur,Radius {parameters.Radius}");
        return Task.CompletedTask;
    }
}