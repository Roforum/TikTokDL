using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokDL
{
    public class Music
    {
        public string id { get; set; }
        public string title { get; set; }
        public string playUrl { get; set; }
        public string coverThumb { get; set; }
        public string coverMedium { get; set; }
        public string authorName { get; set; }
        public bool original { get; set; }
        public string playToken { get; set; }
        public string keyToken { get; set; }
    }
    public class Stats
    {
        public int videoCount { get; set; }
    }
    public class MusicInfo
    {
        public Music music { get; set; }
        public Stats stats { get; set; }
    }
    public class MusicData
    {
        public string musicId { get; set; }
        public string musicName { get; set; }
        public string uniqueId { get; set; }
        public string secUid { get; set; }
        public string authorId { get; set; }
        public string authorName { get; set; }
        public List<string> playUrl { get; set; }
        public List<string> covers { get; set; }
        public int posts { get; set; }
        public bool original { get; set; }
        public List<string> authorCovers { get; set; }
        public List<string> coversMedium { get; set; }
        public string playToken { get; set; }
        public string keyToken { get; set; }
    }
    public class Child
    {
        public string value { get; set; }
        public string label { get; set; }
    }
    public class LanguageList
    {
        public string value { get; set; }
        public string alias { get; set; }
        public string label { get; set; }
        public List<Child> children { get; set; }
    }
    public class Amazon
    {
        public bool visible { get; set; }
        public string normal { get; set; }
    }
    public class Google
    {
        public bool visible { get; set; }
        public string normal { get; set; }
    }
    public class Apple
    {
        public bool visible { get; set; }
        public string normal { get; set; }
    }
    public class DownloadLink
    {
        public Amazon amazon { get; set; }
        public Google google { get; set; }
        public Apple apple { get; set; }
    }
    public class AbTestVersion
    {
        public string clientParameters { get; set; }
        public string clientVersionName { get; set; }
        public string versionName { get; set; }
        public string parameters { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }
    public class LegalList
    {
        public string title { get; set; }
        public string key { get; set; }
        public string href { get; set; }
    }
    public class InitialProps
    {
        public bool _isMobile { get; set; }
        public object _isIOS { get; set; }
        public bool _isAndroid { get; set; }
        public string _host { get; set; }
        public string _pageUrl { get; set; }
        public string _language { get; set; }
        public string _originalLanguage { get; set; }
        public List<LanguageList> _languageList { get; set; }
        public string _region { get; set; }
        public int _appId { get; set; }
        public string _os { get; set; }
        public string _baseURL { get; set; }
        public DownloadLink _downloadLink { get; set; }
        public AbTestVersion _abTestVersion { get; set; }
        public string _appType { get; set; }
        public string _gray { get; set; }
        public string _reflowType { get; set; }
        public List<LegalList> _legalList { get; set; }
    }
    public class PageState
    {
        public int regionAppId { get; set; }
        public string os { get; set; }
        public string region { get; set; }
        public string baseURL { get; set; }
        public string appType { get; set; }
        public string fullUrl { get; set; }
    }
    public class VideoMeta
    {
        public int width { get; set; }
        public int height { get; set; }
        public int ratio { get; set; }
        public int duration { get; set; }
    }
    public class Video
    {
        public List<string> urls { get; set; }
        public VideoMeta videoMeta { get; set; }
    }
    public class ItemInfos
    {
        public string id { get; set; }
        public Video video { get; set; }
        public List<string> covers { get; set; }
        public string authorId { get; set; }
        public List<string> coversOrigin { get; set; }
        public string text { get; set; }
        public int commentCount { get; set; }
        public int diggCount { get; set; }
        public int playCount { get; set; }
        public int shareCount { get; set; }
        public string createTime { get; set; }
        public bool isActivityItem { get; set; }
        public List<object> warnInfo { get; set; }
    }
    public class AuthorInfos
    {
        public bool verified { get; set; }
        public string secUid { get; set; }
        public string uniqueId { get; set; }
        public string userId { get; set; }
        public string nickName { get; set; }
        public List<string> covers { get; set; }
    }
    public class MusicInfos
    {
        public string musicId { get; set; }
        public string musicName { get; set; }
        public string authorName { get; set; }
        public List<string> covers { get; set; }
    }
    public class AuthorStats
    {
        public int followerCount { get; set; }
        public string heartCount { get; set; }
    }
    public class VideoData
    {
        public ItemInfos itemInfos { get; set; }
        public AuthorInfos authorInfos { get; set; }
        public MusicInfos musicInfos { get; set; }
        public AuthorStats authorStats { get; set; }
        public List<object> challengeInfoList { get; set; }
        public string duetInfo { get; set; }
        public List<object> textExtra { get; set; }
    }
    public class ShareUser
    {
        public string secUid { get; set; }
        public string userId { get; set; }
        public string uniqueId { get; set; }
        public string nickName { get; set; }
        public string signature { get; set; }
        public List<object> covers { get; set; }
        public List<object> coversMedium { get; set; }
        public List<object> coversLarger { get; set; }
        public bool isSecret { get; set; }
    }
    public class Image
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
    public class ShareMeta
    {
        public string title { get; set; }
        public string desc { get; set; }
        public Image image { get; set; }
    }
    public class Child2
    {
        public string value { get; set; }
        public string label { get; set; }
    }
    public class LangList
    {
        public string value { get; set; }
        public string alias { get; set; }
        public string label { get; set; }
        public List<Child2> children { get; set; }
    }
    public class ReportReason
    {
        public int audit { get; set; }
        public List<object> next { get; set; }
        public string text { get; set; }
        public int special { get; set; }
        public int type { get; set; }
        public int level { get; set; }
    }
    public class TeaApp
    {
        public bool open { get; set; }
    }
    public class Tea
    {
        public bool open { get; set; }
    }
    public class Config
    {
        public TeaApp teaApp { get; set; }
        public Tea tea { get; set; }
    }
    public class Header
    {
        public bool hidden { get; set; }
    }
    public class Footer
    {
        public bool hidden { get; set; }
    }
    public class PageOptions
    {
        public object headOptions { get; set; }
        public Header header { get; set; }
        public Footer footer { get; set; }
    }
    public class PageProps
    {
        public PageState pageState { get; set; }
        public VideoData videoData { get; set; }
        public ShareUser shareUser { get; set; }
        public ShareMeta shareMeta { get; set; }
        public int statusCode { get; set; }
        public List<LangList> langList { get; set; }
        public string webId { get; set; }
        public string requestId { get; set; }
        public string testId { get; set; }
        public bool isInSeoulTest { get; set; }
        public MusicInfo musicInfo { get; set; }
        public MusicData musicData { get; set; }
        public bool isSSR { get; set; }
        public List<ReportReason> reportReason { get; set; }
        public bool isError { get; set; }
        public Config config { get; set; }
        public PageOptions pageOptions { get; set; }
    }
    public class Props
    {
        public InitialProps initialProps { get; set; }
        public PageProps pageProps { get; set; }
    }
    public class TikTokObj
    {
        public Props props { get; set; }
    }
}
