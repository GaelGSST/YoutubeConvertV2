using VideoLibrary;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace ClassYTConvert
{
    public class ClassYTConv
    {
        //Liste pour des résultats de recherche de la méthode MP3ConvertRecherche
        public static List<string> NomVideoRes = new();
        public static List<string> URLVideoRes = new();

        // Create folder for downloaded musics
        public static void CreateFolder()
        {
            // Folder path 
            var FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DownLoaded_Musics";

            // Try to create folder
            try
            {
                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        public static string extensionDelete(string Name)
        {
            string extension = ".mp4";
            string charTest;
            int indexExtension = 0;

            // On cherche l'emplacement de l'extension
            for (int i = 3; i < Name.Length; i++)
            {
                charTest = $"{Name[i - 3]}{Name[i - 2]}{Name[i - 1]}{Name[i]}";
                if (charTest == extension)
                {
                    indexExtension = i - 3;
                }
            }

            // On retourne le nom sans l'extension avec un slice
            return Name.Substring(0, indexExtension);
        }

        public static string nameVideo(string URL)
        {
            // On récupère la vidéo
            var video = YouTube.Default.GetVideo(URL);

            // On return le nom complet de la vidéo sans l'extension
            return Convert.ToString(extensionDelete(video.FullName));
        }

        public static async Task MP3Convert(string URL, string videoName)
        {
            var Youtube = new YoutubeClient();

            // Installation folder
            var DownloadFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\DownLoaded_Musics\";

            // Take manifest
            var streamManifest = await Youtube.Videos.Streams.GetManifestAsync(URL);
           
            // On filtre la vidéo pour récupérer son audio avec une bonne qualité 
            var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

            // On télécharge l'audio
            await Youtube.Videos.Streams.DownloadAsync(streamInfo, $"{DownloadFile}{videoName}.mp3");

            return;
        }

        public static async Task MP3ConvertPlaylist(string PlaylistURL)
        {
            var Youtube = new YoutubeClient();

            // Take url/tiltle and download it
            await foreach (var video in Youtube.Playlists.GetVideosAsync(PlaylistURL))
            {
                var title = video.Title;
                var URL = video.Url;
                await MP3Convert(URL, title);
            }
        }

        public static async Task MP3ConvertRecherche(string NomVideo)
        {
            var Youtube = new YoutubeClient();

            // Clear list
            NomVideoRes.Clear();
            URLVideoRes.Clear();

            await foreach (var batch in Youtube.Search.GetResultBatchesAsync(NomVideo))
            {
                for (int i = 0; i < 6; i++)
                {
                    if (batch.Items[i].GetType() == typeof(YoutubeExplode.Search.VideoSearchResult))
                    {
                        NomVideoRes.Add(batch.Items[i].Title);
                        URLVideoRes.Add(batch.Items[i].Url);
                    }
                }
                break; // sorry
            }
        }
    }
}