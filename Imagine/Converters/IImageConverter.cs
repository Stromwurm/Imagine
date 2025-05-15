namespace Imagine.Converters;

using OpenCvSharp;

public interface IImageConverter<T1, T2>
{
    T2 Convert(T1 data);
    T1 Convert(T2 data);
}
