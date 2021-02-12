using System.Collections.Generic;
using LineMessagingAPI.Models.Action;
using LineMessagingAPI.Models.Message.Flex.Component;
using LineMessagingAPI.Models.Message.Flex.Container;
using LineMessagingAPI.Models.Message.Flex.Unit;

namespace LineBotSample.Models.SampleFlexMessage
{
    public class PromotionCourseFlexMessage
    {
        public CarouselModel Create()
        {
            #region carousel

            CarouselModel carouselModel = new CarouselModel();

            List<BubbleModel> carouselContentList = new List<BubbleModel>();

            for (int i = 0; i <= 3; i++)
            {
                #region body_bubble_1

                BubbleModel bubbleModel = new BubbleModel();

                #region box_1

                //box
                BoxModel mainBoxModel = new BoxModel()
                {
                    layout = FlexLayout.vertical
                };
                List<FlexComponentModel> mainboxModelList = new List<FlexComponentModel>();

                #region box_1_content_1

                //text
                TextModel contentModel1 = new TextModel()
                {
                    text = "abc",
                    color = "#ffffff",
                    size = FlexFontSize.sm
                };
                mainboxModelList.Add(contentModel1);

                #endregion

                #region box_1_content_2

                //text 課程標題
                TextModel contentModel2 = new TextModel()
                {
                    text = "課程標題",
                    size = FlexFontSize.xxl,
                    weight = TextWeight.regular,
                    margin = FlexMarginSize.md,
                    wrap = true
                };
                mainboxModelList.Add(contentModel2);

                #endregion

                #region box_1_content_3

                //text
                TextModel contentModel3 = new TextModel()
                {
                    text = "老師",
                    size = FlexFontSize.sm,
                };
                mainboxModelList.Add(contentModel3);

                #endregion

                #region box_1_content_4

                //text 課程副標題
                TextModel contentModel4 = new TextModel()
                {
                    text = "課程副標題",
                    size = FlexFontSize.sm,
                    color = "#aaaaaa",
                    wrap = true,
                    offsetTop = "5px"
                };
                mainboxModelList.Add(contentModel4);

                #endregion

                #region box_1_content_5

                //box
                BoxModel contentModel5 = new BoxModel()
                {
                    layout = FlexLayout.baseline,
                    margin = FlexMarginSize.xl,
                    spacing = FlexMarginSize.xxl
                };
                List<FlexComponentModel> contentModel5List = new List<FlexComponentModel>();

                #region box_1_content_5_content_1

                //text 原價
                TextModel contentModel5To1 = new TextModel()
                {
                    text = "NT$ 1000",
                    size = FlexFontSize.sm,
                    flex = 0,
                    decoration = TextDecoration.line_through,
                    gravity = FlexGravity.top,
                    offsetTop = "-2px"
                };
                contentModel5List.Add(contentModel5To1);

                #endregion

                #region box_1_content_5_content_2

                //text 特價
                TextModel contentModel5To2 = new TextModel()
                {
                    text = "NT$ 800",
                    size = FlexFontSize.lg,
                    color = "#ff0000",
                    flex = 0,
                    gravity = FlexGravity.bottom
                };
                contentModel5List.Add(contentModel5To2);

                #endregion

                contentModel5.contents = contentModel5List;
                mainboxModelList.Add(contentModel5);

                #endregion

                #region box_1_content_6

                //box
                BoxModel contentModel6 = new BoxModel()
                {
                    layout = FlexLayout.baseline,
                    spacing = FlexMarginSize.md,
                    paddingTop = "10px"
                };
                List<FlexComponentModel> contentModel6List = new List<FlexComponentModel>();

                #region box_1_content_6_content_1

                //text 課程開始日期
                TextModel contentModel6To1 = new TextModel()
                {
                    text = "課程開始日期：",
                    flex = 0
                };
                contentModel6List.Add(contentModel6To1);

                #endregion

                #region box_1_content_6_content_2

                //text 課程開始日期
                TextModel contentModel6To2 = new TextModel()
                {
                    text = "2018/9/22",
                    flex = 0,
                    offsetTop = "1px"
                };
                contentModel6List.Add(contentModel6To2);

                #endregion

                contentModel6.contents = contentModel6List;
                mainboxModelList.Add(contentModel6);

                #endregion

                #region box_1_content_7

                //box
                BoxModel contentModel7 = new BoxModel()
                {
                    layout = FlexLayout.baseline,
                    spacing = FlexMarginSize.md
                };
                List<FlexComponentModel> contentModel7List = new List<FlexComponentModel>();

                #region box_1_content_7_content_1

                //text 課程結束日期
                TextModel contentModel7To1 = new TextModel()
                {
                    text = "課程結束日期：",
                    flex = 0
                };
                contentModel7List.Add(contentModel7To1);

                #endregion

                #region box_1_content_7_content_2

                //text 課程結束日期
                TextModel contentModel7To2 = new TextModel()
                {
                    text = "2019/12/13",
                    flex = 0,
                    offsetTop = "1px"
                };
                contentModel7List.Add(contentModel7To2);

                #endregion

                contentModel7.contents = contentModel7List;
                mainboxModelList.Add(contentModel7);

                #endregion

                #region box_1_content_8

                //box
                BoxModel contentModel8 = new BoxModel()
                {
                    layout = FlexLayout.baseline,
                    spacing = FlexMarginSize.md
                };
                List<FlexComponentModel> contentModel8List = new List<FlexComponentModel>();

                #region box_1_content_8_content_1

                //text 上課時段
                TextModel contentModel8To1 = new TextModel()
                {
                    text = "上課時段：",
                    flex = 0
                };
                contentModel8List.Add(contentModel8To1);

                #endregion

                #region box_1_content_8_content_2

                //text 上課時段
                TextModel contentModel8To2 = new TextModel()
                {
                    text = "六 09:00~16:00",
                    flex = 0,
                    wrap = true,
                    maxLines = 3
                };
                contentModel8List.Add(contentModel8To2);

                #endregion

                contentModel8.contents = contentModel8List;
                mainboxModelList.Add(contentModel8);

                #endregion

                #region box_1_content_9

                //box
                BoxModel contentModel9 = new BoxModel()
                {
                    layout = FlexLayout.baseline,
                    spacing = FlexMarginSize.md
                };
                List<FlexComponentModel> contentModel9List = new List<FlexComponentModel>();

                #region box_1_content_9_content_1

                //text 地點
                TextModel contentModel9To1 = new TextModel()
                {
                    text = "地點：",
                    flex = 0
                };
                contentModel9List.Add(contentModel9To1);

                #endregion

                #region box_1_content_9_content_2

                //text 地點
                TextModel contentModel9To2 = new TextModel()
                {
                    text = "台北市OO路OO號台北市OO路OO號台北市OO路OO號",
                    flex = 0,
                    wrap = true,
                    maxLines = 3
                };
                contentModel9List.Add(contentModel9To2);

                #endregion

                contentModel9.contents = contentModel9List;
                mainboxModelList.Add(contentModel9);

                #endregion

                #region box_1_content_10

                //box
                BoxModel contentModel10 = new BoxModel()
                {
                    layout = FlexLayout.vertical,
                    position = FlexPosition.absolute,
                    width = "53px",
                    height = "25px",
                    backgroundColor = "#ff334b",
                    cornerRadius = "20px",
                    offsetTop = "18px",
                    offsetStart = "18px"
                };
                List<FlexComponentModel> contentModel10List = new List<FlexComponentModel>();

                #region box_1_content_10_content_1

                //text
                TextModel contentModel10To1 = new TextModel()
                {
                    text = "SALE",
                    size = FlexFontSize.xs,
                    color = "#ffffff",
                    align = FlexAlign.center,
                    offsetTop = "5px"
                };
                contentModel10List.Add(contentModel10To1);

                #endregion

                contentModel10.contents = contentModel10List;
                mainboxModelList.Add(contentModel10);

                #endregion

                #endregion

                mainBoxModel.contents = mainboxModelList;

                #endregion

                bubbleModel.body = mainBoxModel;


                #region footer

                #region footer_box_1

                //box
                BoxModel footerContent1 = new BoxModel()
                {
                    layout = FlexLayout.vertical,
                    flex = 0,
                    spacing = FlexMarginSize.sm
                };
                List<FlexComponentModel> footerContent1List = new List<FlexComponentModel>();

                #region footer_box_1_content_1

                //button 更多資訊
                URIActionModel footerContent1To1Action1 = new URIActionModel()
                {
                    label = "更多資訊",
                    uri = "https://www.example.com"
                };
                ButtonModel footerContent1To1 = new ButtonModel()
                {
                    action = footerContent1To1Action1,
                    height = ButtonHeight.sm
                };
                footerContent1List.Add(footerContent1To1);

                #endregion

                #region footer_box_1_content_2

                //button 購買
                URIActionModel footerContent1To2Action1 = new URIActionModel()
                {
                    label = "購買",
                    uri = "https://www.example.com"
                };
                ButtonModel footerContent1To2 = new ButtonModel()
                {
                    action = footerContent1To2Action1,
                    height = ButtonHeight.sm
                };
                footerContent1List.Add(footerContent1To2);

                #endregion

                footerContent1.contents = footerContent1List;
                bubbleModel.footer = footerContent1;

                #endregion

                #endregion

                #endregion

                carouselContentList.Add(bubbleModel);
            }
            carouselModel.contents = carouselContentList;

            return carouselModel;
        }

                /// <summary>
        /// 用Json傳遞
        /// </summary>
        /// <returns></returns>
        public string CreateWithJson()
        {
            string name = "課程標題";
            string teacher = "老師";
            string subName = "課程副標題";
            string originPrice = "1000";
            string unitPrice = "800";
            string openDate = "2018/9/22";
            string endDate = "2019/12/13";
            string period = "六 09:00~16:00";
            string address = "台北市OO路OO號台北市OO路OO號台北市OO路OO號";

            string result = "";

            string part1 = $@"
  {{
    ""type"": ""flex"",
    ""altText"": ""優惠課程"",
    ""contents"": {{
      ""type"": ""carousel"",
      ""contents"": [";

            string courses = string.Empty;

            for (int i = 0; i <= 9; i++)
            {
                string lastComma = "";

                if (i == 9)
                {
                    lastComma = @"";
                }
                else
                {
                    lastComma = @",";
                }

                courses = courses + $@"
        {{
          ""type"": ""bubble"",
          ""body"": {{
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {{
                ""type"": ""text"",
                ""text"": ""abc"",
                ""size"": ""sm"",
                ""color"": ""#ffffff""
              }},
              {{
                ""type"": ""text"",
                ""text"": ""{name}"",
                ""margin"": ""md"",
                ""size"": ""xxl"",
                ""weight"": ""regular"",
                ""wrap"": true
              }},
              {{
                ""type"": ""text"",
                ""text"": ""{teacher}"",
                ""size"": ""sm""
              }},
              {{
                ""type"": ""text"",
                ""text"": ""{subName}"",
                ""offsetTop"": ""5px"",
                ""size"": ""sm"",
                ""color"": ""#aaaaaa"",
                ""wrap"": true
              }},
              {{
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""contents"": [
                  {{
                    ""type"": ""text"",
                    ""text"": ""NT$ {originPrice}"",
                    ""flex"": 0,
                    ""offsetTop"": ""-2px"",
                    ""size"": ""sm"",
                    ""gravity"": ""top"",
                    ""decoration"": ""line-through""
                  }},
                  {{
                    ""type"": ""text"",
                    ""text"": ""NT$ {unitPrice}"",
                    ""flex"": 0,
                    ""size"": ""lg"",
                    ""gravity"": ""bottom"",
                    ""color"": ""#ff0000""
                  }}
                ],
                ""spacing"": ""xxl"",
                ""margin"": ""xl""
              }},
              {{
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""contents"": [
                  {{
                    ""type"": ""text"",
                    ""text"": "" 課程開始日期："",
                    ""flex"": 0
                  }},
                  {{
                    ""type"": ""text"",
                    ""text"": ""{openDate}"",
                    ""flex"": 0,
                    ""offsetTop"": ""1px""
                  }}
                ],
                ""spacing"": ""md"",
                ""paddingTop"": ""10px""
              }},
              {{
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""contents"": [
                  {{
                    ""type"": ""text"",
                    ""text"": ""課程結束日期："",
                    ""flex"": 0
                  }},
                  {{
                    ""type"": ""text"",
                    ""text"": ""{endDate}"",
                    ""flex"": 0,
                    ""offsetTop"": ""1px""
                  }}
                ],
                ""spacing"": ""md""
              }},
              {{
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""contents"": [
                  {{
                    ""type"": ""text"",
                    ""text"": ""上課時段："",
                    ""flex"": 0
                  }},
                  {{
                    ""type"": ""text"",
                    ""text"": ""{period}"",
                    ""flex"": 0,
                    ""wrap"": true,
                    ""maxLines"": 3
                  }}
                ],
                ""spacing"": ""md""
              }},
              {{
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""contents"": [
                  {{
                    ""type"": ""text"",
                    ""text"": ""地點："",
                    ""flex"": 0
                  }},
                  {{
                    ""type"": ""text"",
                    ""text"": ""{address}"",
                    ""flex"": 0,
                    ""wrap"": true,
                    ""maxLines"": 3
                  }}
                ],
                ""spacing"": ""md""
              }},
              {{
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {{
                    ""type"": ""text"",
                    ""text"": ""SALE"",
                    ""offsetTop"": ""5px"",
                    ""size"": ""xs"",
                    ""align"": ""center"",
                    ""color"": ""#ffffff""
                  }}
                ],
                ""backgroundColor"": ""#ff334b"",
                ""cornerRadius"": ""20px"",
                ""width"": ""53px"",
                ""height"": ""25px"",
                ""position"": ""absolute"",
                ""offsetTop"": ""18px"",
                ""offsetStart"": ""18px""
              }}
            ]
          }},
          ""footer"": {{
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {{
                ""type"": ""button"",
                ""action"": {{
                  ""type"": ""uri"",
                  ""label"": ""更多資訊"",
                  ""uri"": ""https://www.example.com""
                }},
                ""height"": ""sm""
              }},
              {{
                ""type"": ""button"",
                ""action"": {{
                  ""type"": ""uri"",
                  ""label"": ""購買"",
                  ""uri"": ""https://www.example.com""
                }},
                ""height"": ""sm""
              }}
            ],
            ""flex"": 0,
            ""spacing"": ""sm""
          }}
        }}{lastComma}";
            }

            string part2 = courses;

            string part3 = $@"      ]
    }}
  }}";

            result = part1 + part2 + part3;

            return result;
        }

        /// <summary>
        /// 原始Json格式
        /// </summary>
        /// <returns></returns>
        private string OriginalJson()
        {
            string result = @"[
  {
    ""type"": ""flex"",
    ""altText"": ""優惠課程"",
    ""contents"": {
      ""type"": ""carousel"",
      ""contents"": [
        {
          ""type"": ""bubble"",
          ""body"": {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""abc"",
                ""size"": ""sm"",
                ""color"": ""#ffffff""
              },
              {
                ""type"": ""text"",
                ""text"": ""課程標題"",
                ""margin"": ""md"",
                ""size"": ""xxl"",
                ""weight"": ""regular"",
                ""wrap"": true
              },
              {
                ""type"": ""text"",
                ""text"": ""老師"",
                ""size"": ""sm""
              },
              {
                ""type"": ""text"",
                ""text"": ""課程副標題"",
                ""offsetTop"": ""5px"",
                ""size"": ""sm"",
                ""color"": ""#aaaaaa"",
                ""wrap"": true
              },
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""NT$ 1000"",
                    ""flex"": 0,
                    ""offsetTop"": ""-2px"",
                    ""size"": ""sm"",
                    ""gravity"": ""top"",
                    ""decoration"": ""line-through""
                  },
                  {
                    ""type"": ""text"",
                    ""text"": ""NT$ 800"",
                    ""flex"": 0,
                    ""size"": ""lg"",
                    ""gravity"": ""bottom"",
                    ""color"": ""#ff0000""
                  }
                ],
                ""spacing"": ""xxl"",
                ""margin"": ""xl""
              },
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": "" 課程開始日期："",
                    ""flex"": 0
                  },
                  {
                    ""type"": ""text"",
                    ""text"": ""2018/9/22"",
                    ""flex"": 0,
                    ""offsetTop"": ""1px""
                  }
                ],
                ""spacing"": ""md"",
                ""paddingTop"": ""10px""
              },
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""課程結束日期："",
                    ""flex"": 0
                  },
                  {
                    ""type"": ""text"",
                    ""text"": ""2019/12/13"",
                    ""flex"": 0,
                    ""offsetTop"": ""1px""
                  }
                ],
                ""spacing"": ""md""
              },
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""上課時段："",
                    ""flex"": 0
                  },
                  {
                    ""type"": ""text"",
                    ""text"": ""六 09:00~16:00"",
                    ""flex"": 0,
                    ""wrap"": true,
                    ""maxLines"": 3
                  }
                ],
                ""spacing"": ""md""
              },
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""地點："",
                    ""flex"": 0
                  },
                  {
                    ""type"": ""text"",
                    ""text"": ""台北市OO路OO號台北市OO路OO號台北市OO路OO號"",
                    ""flex"": 0,
                    ""wrap"": true,
                    ""maxLines"": 3
                  }
                ],
                ""spacing"": ""md""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""SALE"",
                    ""offsetTop"": ""5px"",
                    ""size"": ""xs"",
                    ""align"": ""center"",
                    ""color"": ""#ffffff""
                  }
                ],
                ""backgroundColor"": ""#ff334b"",
                ""cornerRadius"": ""20px"",
                ""width"": ""53px"",
                ""height"": ""25px"",
                ""position"": ""absolute"",
                ""offsetTop"": ""18px"",
                ""offsetStart"": ""18px""
              }
            ]
          },
          ""footer"": {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""button"",
                ""action"": {
                  ""type"": ""uri"",
                  ""label"": ""更多資訊"",
                  ""uri"": ""https://www.example.com""
                },
                ""height"": ""sm""
              },
              {
                ""type"": ""button"",
                ""action"": {
                  ""type"": ""uri"",
                  ""label"": ""購買"",
                  ""uri"": ""https://www.example.com""
                },
                ""height"": ""sm""
              }
            ],
            ""flex"": 0,
            ""spacing"": ""sm""
          }
        }
      ]
    }
  }
]";

            return result;
        }
    }
}