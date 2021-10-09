# TileFetcher
地图瓦片下载程序，支持常用的互联网地图片。下载完成以后，可以自动合并并存为TIFF文件。
此程序是中南大学李光强（Ligq168@csu.edu.cn）在Zheng Jie（https://github.com/zhengjie9510/google-map-downloader）编写的Python程序的基础上，修改完成。
坐标系采用WGS84.


## 程序使用C# (.net 4.5.2)和Python混合开发

- 地图使用百度地图API v2.0，在主界面中显示的坐标为WGS84，程序已经将BD09转为WGS84.
- 如果下载Google地图瓦片，需要翻墙
- 如果下载天地图（Tianditu）地图瓦片，下载最高层级不能超过18. 

