
namespace Imagine.Transformers;

public interface IImageTransformerMem
{
    Memory<byte>[] Transform(Memory<byte>[] data);
    Memory<byte> Transform(Memory<byte> data);
}

public interface IImageTransformerMat
{
    OpenCvSharp.Mat[] Transform(OpenCvSharp.Mat[] data);
    OpenCvSharp.Mat Transform(OpenCvSharp.Mat data);
}