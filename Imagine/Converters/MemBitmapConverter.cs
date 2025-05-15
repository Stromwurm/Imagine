namespace Imagine.Converters;

using System.Drawing;
using System.Drawing.Imaging;

public class MemBitmapConverter : IImageConverter<Bitmap, Memory<byte>>
{
    private ImageFormat? _imageFormat = ImagineContext.GetImageFormat();
    public ImageFormat? ImageFormat
    {
        get
        {
            return _imageFormat;
        }

        set
        {
            if (_imageFormat == value)
                return;

            _imageFormat = value;
        }
    }
    public Memory<byte> Convert(Bitmap data)
    {
        if (_imageFormat is null)
            throw new InvalidOperationException("No ImageFormat!");

        using MemoryStream m = new();
        data.Save(m, _imageFormat);

        return m.GetBuffer();
    }

    public Bitmap Convert(Memory<byte> data)
    {
        using MemoryStream ms = new();
        ms.Read(data.Span);

        Bitmap m = new(ms);

        return m;
    }
}