namespace Imagine.Transformers;

using OpenCvSharp;

public interface IImageTransformer<TIn, TOut>
{
    TOut[] TransformMultipleImages(TIn[] data);
    TOut TransformSingleImage(TIn data);
}
