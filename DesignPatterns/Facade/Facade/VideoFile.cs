namespace Facade;

public class VideoFile
{
    private string _filename;
    
    public VideoFile(string filename)
    {
        _filename = filename;
    }
    
    public override string ToString()
    {
        return _filename;
    }
}

