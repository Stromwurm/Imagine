namespace Imagine.Converters;

using System.Collections;

using OpenCvSharp;

public class MatMemConverter : IImageConverter<Memory<byte>, Mat>
{
    private ImreadModes _modes = 0;
    public ImreadModes Modes
    {
        get
        {
            return _modes;
        }
        set
        {
            if (_modes == value)
                return;

            _modes = value;
        }
    }

    public MatMemConverter(ImreadModes? modes = null)
    {
        if (modes != null)
            _modes = modes.Value;
    }

    public Mat Convert(Memory<byte> data)
    {
        var m = Cv2.ImDecode(data.Span, _modes);
        return m;
    }

    public Memory<byte> Convert(Mat data)
    {
        var m = data.ImEncode(ImagineContext.ImEncodeExtension);
        return m;
    }
}

public class MatMemArrayConverter : IImageConverter<Memory<byte>[], Mat[]>
{
    private ImreadModes _modes = 0;
    public ImreadModes Modes
    {
        get
        {
            return _modes;
        }
        set
        {
            if (_modes == value)
                return;

            _modes = value;
        }
    }

    public MatMemArrayConverter(ImreadModes? modes = null)
    {
        if (modes != null)
            _modes = modes.Value;
    }

    public Mat[] Convert(Memory<byte>[] data)
    {
        Mat[] m = new Mat[data.Length];

        for (int i = 0; i < data.Length; i++)
        {
            m[i] = Cv2.ImDecode(data[i].Span, _modes);
        }

        return m;
    }

    public Memory<byte>[] Convert(Mat[] data)
    {
        Memory<byte>[] m = new Memory<byte>[data.Length];

        for (int i = 0; i < data.Length; i++)
        {
            m[i] = data[i].ImEncode(ImagineContext.ImEncodeExtension);

        }

        return m;
    }
}

public class ImagineObject : IDisposable
{
    private readonly string _file = string.Empty;
    public string File => _file;

    private Mat? _image;

    public ImagineObject(string file)
    {
        _file = file;
    }

    public void Load()
    {
        _image = new (_file);
    }

    public void Transform()
    {
        _image.
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}