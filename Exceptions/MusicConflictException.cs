using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Models
{
    public class MusicConflictException : Exception
    {
        //may use this or not
        public MusicFile ExistingMusicFile { get; }
        public MusicFile IncomingMusicFile { get; }

        public MusicConflictException(string message, MusicFile existingMusicFile, MusicFile incomingMusicFile) : base(message)
        {
            ExistingMusicFile=existingMusicFile;
            IncomingMusicFile=incomingMusicFile;
        }

        public MusicConflictException(string message, Exception innerException, MusicFile existingMusicFile = null, MusicFile incomingMusicFile = null) : base(message, innerException)
        {
            ExistingMusicFile=existingMusicFile;
            IncomingMusicFile=incomingMusicFile;
        }

        public MusicConflictException(MusicFile existingMusicFile, MusicFile incomingMusicFile)
        {
            ExistingMusicFile=existingMusicFile;
            IncomingMusicFile=incomingMusicFile;
        }
    }
}
