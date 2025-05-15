namespace Imagine;

using System.Drawing.Imaging;

using Imagine.Converters;
using Imagine.Transformers;

using OpenCvSharp;

public static class ImagineContext
{
    public static event EventHandler<string> ImEncodeExtensionChanged;
    private static string _imEncodeExtension = ".bmp";
    public static string ImEncodeExtension
    {
        get
        {
            return _imEncodeExtension;
        }

        set
        {
            if (_imEncodeExtension == value)
                return;

            _imEncodeExtension = value;
            ImEncodeExtensionChanged.Invoke(null, _imEncodeExtension);
        }
    }

    public static IImageConverter<Memory<byte>, Mat> MatToMem = new MatMemConverter();
    public static IImageConverter<Memory<byte>[], Mat[]> MatToMemArray = new MatMemArrayConverter();

    private static List<IImageTransformerMat> _transformers;
    public static IImageTransformerMat[] Transformers => [.._transformers];

    public static Mat DecodeAsMat(this Memory<byte> data)
    {
        return MatToMem.Convert(data);
    }

    public static Mat[] DecodeAsMat(this Memory<byte>[] data)
    {
        return MatToMemArray.Convert(data);
    }

    public static Memory<byte> EncodeAsMem(this Mat data)
    {
        return MatToMem.Convert(data);
    }

    public static Memory<byte>[] EncodeAsMem(this Mat[] data)
    {
        return MatToMemArray.Convert(data);

    }

    public static ImageFormat? GetImageFormat()
    {
        if (ImEncodeExtension == ".bmp")
            return ImageFormat.Bmp;
        else if (ImEncodeExtension == ".png")
            return ImageFormat.Png;
        else if (ImEncodeExtension == ".tiff")
            return ImageFormat.Tiff;
        else if (ImEncodeExtension == ".jpg")
            return ImageFormat.Jpeg;
        else
            return null;
    }


}
