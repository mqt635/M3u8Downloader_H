﻿using M3u8Downloader_H.Common.M3u8Infos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace M3u8Downloader_H.M3U8.M3UFileReaderManangers
{
    public interface IM3UFileInfoMananger
    {
        TimeSpan TimeOuts { set; }

        //通过http方式请求数据
        Task<M3UFileInfo> GetM3u8FileInfo(Uri uri, IEnumerable<KeyValuePair<string, string>>? headers, CancellationToken cancellationToken = default);

        //通过直接传入m3u8文件请求数据
        public M3UFileInfo GetM3u8FileInfo(Uri uri, string content);

        //通过传入本地文件如xml,json,m3u8,文件夹等方式请求数据
        public M3UFileInfo GetM3u8FileInfo(string ext, Uri uri);
    }
}
