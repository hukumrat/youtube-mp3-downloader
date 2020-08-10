# youtube-mp3-downloader

 It's a simple youtube mp3 converter. <br/>

## Description
 
 This tool retrieves video's infos. Extracts the '.webm' URL of video using [Tyrrrzz's YoutubeExplode](https://github.com/Tyrrrz/YoutubeExplode). Downloads the data using WebClient. Converts the '.webm' file to '.mp3' file using [AydinAdn's Mediatoolkit](https://github.com/AydinAdn/MediaToolkit).

## Getting Started

### Dependencies
  * You should have Windows OS to use this tool.
  * You should install [Tyrrrzz's Youtubeexplode](https://github.com/Tyrrrz/YoutubeExplode) [AydinAdn's Mediatoolkit](https://github.com/AydinAdn/MediaToolkit) in your IDE to edit the project.
  
### Installing
  * Firstly, you should adjust your download folder in settings tab.(with typing, browsing or dragging&dropping)

### Executing Program
  * Copy your Youtube URL.
  * Click on the upper on the left(Add URL Button).
  * The program will paste automatically the your URL if it matches the program's Youtube URL Regex. The Regular Expression of the tool matches more than 30 Youtube URLs.(short version, embed, mixed and attribution urls).
  * Click on "Add to queue".
  * Your URL will be added in the queue. 
  * You can double click on the Row in the queue to reach your download folder.
  
## Version History
  * 1.0
    * Initial relase.
    
## Acknowledgments
  The tools was used:<br/>
      * [Tyrrrzz's YoutubeExplode](https://github.com/Tyrrrz/YoutubeExplode) to get Youtube Video's metadatas and datas.<br/>
      * [AydinAdn's Mediatoolkit](https://github.com/AydinAdn/MediaToolkit) to convert the downloaded file to 'mp3'.<br/>
  For designing:<br/>
      * [Bunifu Framework](https://bunifuframework.com/)<br/>
      * [MetroFramework](https://thielj.github.io/MetroFramework/)<br/>
      * [DevExpress](https://www.devexpress.com/)<br/>
