using ImagePlugin.Models;

namespace ImagePlugin.Interfaces;

public interface IPlugin
{
    string Name { get; }
    Task Process(ImageData imageData, object parameters);
}