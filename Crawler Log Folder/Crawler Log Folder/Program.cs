using Crawler_Log_Folder;

string[] logs1 = { "d1/", "d2/", "../", "d21/", "./" };
string[] logs2 = { "d1/", "d2/", "./", "d3/", "../", "d31/" };
string[] logs3 = { "d1/", "../", "../", "../" };

Console.WriteLine("logs1's crawling foler: " + new Solution().MinOperations(logs1));
Console.WriteLine("logs2's crawling foler: " + new Solution().MinOperations(logs2));
Console.WriteLine("logs3's crawling foler: " + new Solution().MinOperations(logs3));