﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.BookReader.Models
{
    public class Rankings
    {
        /**
     * _id : 54d42d92321052167dfb75e3
     * updated : 2016-08-14T21:20:21.090Z
     * title : 追书最热榜 Top100
     * tag : zhuishuLatelyFollowerMale
     * cover : /ranking-cover/142319144267827
     * __v : 509
     * monthRank : 564d820bc319238a644fb408
     * totalRank : 564d8494fe996c25652644d2
     * isSub : false
     * collapse : false
     * new : true
     * gender : male
     * priority : 250
     * books : [{"_id":"53855a750ac0b3a41e00c7e6","title":"择天记","author":"猫腻",
     * "shortIntro":"太始元年，有神石自太空飞来，分散落在人间，其中落在东土大陆的神石，上面镌刻着奇怪的图腾，人因观其图腾而悟道，后立国教。
     * 数千年后，十四岁的少年孤儿陈长生，为治病...","cover":"/agent/http://image.cmfu.com/books/3347595/3347595.jpg",
     * "site":"qidian","cat":"玄幻","banned":0,"latelyFollower":182257,"latelyFollowerBase":0,
     * "minRetentionRatio":0,"retentionRatio":"52.48"}]
     * created : 2015-02-06T02:57:22.000Z
     * id : 54d42d92321052167dfb75e3
     */

        public RankingBean ranking;

        public class RankingBean
        {
            public String _id;
            public String updated;
            public String title;
            public String tag;
            public String cover;
            public int __v;
            public String monthRank;
            public String totalRank;
            public bool isSub;
            public bool collapse;
            [JsonProperty("new")]
            public bool newX;
            public String gender;
            public int priority;
            public String created;
            public String id;
            /**
             * _id : 53855a750ac0b3a41e00c7e6
             * title : 择天记
             * author : 猫腻
             * shortIntro : 太始元年，有神石自太空飞来，分散落在人间，其中落在东土大陆的神石，上面镌刻着奇怪的图腾，人因观其图腾而悟道，后立国教。 数千年后，十四岁的少年孤儿陈长生，为治病...
             * cover : /agent/http://image.cmfu.com/books/3347595/3347595.jpg
             * site : qidian
             * cat : 玄幻
             * banned : 0
             * latelyFollower : 182257
             * latelyFollowerBase : 0
             * minRetentionRatio : 0
             * retentionRatio : 52.48
             */

            public List<BooksBean> books;

            public class BooksBean
            {
                public String _id;
                public String title;
                public String author;
                public String shortIntro;
                public String cover;
                public String site;
                public String cat;
                public int banned;
                public int latelyFollower;
                public int latelyFollowerBase;
                public String minRetentionRatio;
                public String retentionRatio;
            }
        }
    }
}
