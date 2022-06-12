using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Models
{
    internal class MusicLibrary
    {
        //Source: https://youtu.be/fZxZswmC_BY?t=550

        private readonly List<MusicFile> _musicFiles;

        public MusicLibrary()
        {
            _musicFiles = new List<MusicFile>();
        }

        public List<MusicFile> GetMusicBySearch(string query)
        {
            List<MusicFile> tempList = new List<MusicFile>();

            foreach (MusicFile file in _musicFiles)
            {
                if (file.title.ToLower().Contains(query))
                {
                    tempList.Add(file);
                }
            }

            return tempList;
        }

        public MusicFile GetMusicByIndex(int Index)
        {
            return _musicFiles.Where(x => x.index == Index).FirstOrDefault();
        }
        
        public MusicFile GetMusicByTitle(string title)
        {
            return _musicFiles.Where(x => x.title == title).FirstOrDefault();
        }

        public MusicFile GetRandomMusic()
        {
            return _musicFiles.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
        }
        public List<MusicFile> GetMusicList()
        {
            return _musicFiles;
        }

        public List<MusicFile> SortListByDuration()
        {
            return _musicFiles.OrderBy(o => o.duration).ToList();
        }

        public List<MusicFile> SortListByTitle()
        {
            return _musicFiles.OrderBy(o => o.title).ToList(); ;
        }

        public void AddMusic(MusicFile music)
        {
            _musicFiles.Add(music);
        }

        public void DeleteMusic(MusicFile music)
        {
            _musicFiles.Remove(music);
        }
    }
}
