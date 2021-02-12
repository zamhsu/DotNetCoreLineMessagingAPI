using System;
using System.Collections.Generic;
using LineMessagingAPI.Models.Message.Flex.Component;
using LineMessagingAPI.Models.Message.Flex.Container;
using LineMessagingAPI.Models.Message.Flex.Unit;

namespace LineBotSample.Models.SampleFlexMessage
{
    public class ApparelFlexMessage
    {
        public BubbleModel CreateEasy()
        {
            BubbleModel bubbleModel = new BubbleModel();

            BoxModel boxModel = new BoxModel()
            {
                layout = FlexLayout.vertical
            };
            List<FlexComponentModel> boxModelContentsList = new List<FlexComponentModel>();
            TextModel textModel1 = new TextModel()
            {
                text = "hello"
            };
            TextModel textModel2 = new TextModel()
            {
                text = "world"
            };
            boxModelContentsList.Add(textModel1);
            boxModelContentsList.Add(textModel2);

            boxModel.contents = boxModelContentsList;

            bubbleModel.body = boxModel;

            return bubbleModel;
        }

        public CarouselModel Create()
        {
            #region carousel

            CarouselModel carouselModel = new CarouselModel();

            List<BubbleModel> carouselContentList = new List<BubbleModel>();

            #region body_bubble_1

            BubbleModel bubbleModel = new BubbleModel();

            #region box_1

            BoxModel mainBoxModel = new BoxModel()
            {
                layout = FlexLayout.vertical,
                paddingAll = "0px"
            };
            List<FlexComponentModel> mainboxModelList = new List<FlexComponentModel>();

            #region box_1_content_1

            ImageModel contentModel1 = new ImageModel()
            {
                url = "https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip1.jpg",
                size = ImageSize.full,
                aspectMode = ImageAspectMode.cover,
                aspectRatio = ImageAspectRatio.R2To3,
                gravity = FlexGravity.top
            };
            mainboxModelList.Add(contentModel1);

            #endregion

            #region box_1_content_2

            BoxModel contentModel2 = new BoxModel()
            {
                layout = FlexLayout.vertical,
                spacing = FlexMarginSize.lg,
                position = FlexPosition.absolute,
                backgroundColor = "#03303Acc",
                paddingAll = "20px",
                paddingTop = "18px",
                offsetBottom = "0px",
                offsetStart = "0px",
                offsetEnd = "0px"
            };
            List<FlexComponentModel> contentModel2List = new List<FlexComponentModel>();

            #region box_1_content_2_content_1

            BoxModel contentModel2To1 = new BoxModel();
            contentModel2To1.layout = FlexLayout.vertical;
            List<FlexComponentModel> contentModel2To1List = new List<FlexComponentModel>();

            #region box_1_content_2_content_1_content1

            TextModel contentModel2To1To1 = new TextModel()
            {
                text = "Brown's T-shirts",
                size = FlexFontSize.xl,
                color = "#ffffff",
                weight = TextWeight.bold
            };
            contentModel2To1List.Add(contentModel2To1To1);

            #endregion

            #endregion

            contentModel2To1.contents = contentModel2To1List;
            contentModel2List.Add(contentModel2To1);

            #region box_1_content_2_content_2

            BoxModel contentModel2To2 = new BoxModel()
            {
                layout = FlexLayout.baseline,
                spacing = FlexMarginSize.lg,
            };
            List<FlexComponentModel> contentModel2To2List = new List<FlexComponentModel>();

            #region box_1_content_2_content_2_content1

            TextModel contentModel2To2To1 = new TextModel()
            {
                text = "¥35,800",
                color = "#ebebeb",
                size = FlexFontSize.sm,
                flex = 0
            };
            contentModel2To2List.Add(contentModel2To2To1);

            #endregion

            #region box_1_content_2_content_2_content2

            TextModel contentModel2To2To2 = new TextModel()
            {
                text = "¥75,000",
                color = "#ffffffcc",
                decoration = TextDecoration.line_through,
                gravity = FlexGravity.bottom,
                flex = 0,
                size = FlexFontSize.sm
            };
            contentModel2To2List.Add(contentModel2To2To2);

            #endregion

            #endregion

            contentModel2To2.contents = contentModel2To2List;
            contentModel2List.Add(contentModel2To2);

            #region box_1_content_2_content_3

            BoxModel contentModel2To3 = new BoxModel()
            {
                layout = FlexLayout.vertical,
                borderWidth = "1px",
                cornerRadius = "4px",
                spacing = FlexMarginSize.sm,
                borderColor = "#ffffff",
                margin = FlexMarginSize.xxl,
                height = "40px"
            };
            List<FlexComponentModel> contentModel2To3List = new List<FlexComponentModel>();

            #region box_1_content_2_content_3_content_1

            FillerModel contentModel2To3To1 = new FillerModel();
            contentModel2To3List.Add(contentModel2To3To1);

            #endregion

            #region box_1_content_2_content_3_content_2

            BoxModel contentModel2To3To2 = new BoxModel()
            {
                layout = FlexLayout.baseline,
                spacing = FlexMarginSize.sm
            };
            List<FlexComponentModel> contentModel2To3To2List = new List<FlexComponentModel>();

            #region box_1_content_2_content_3_content_2_content1

            FillerModel contentModel2To3To2To1 = new FillerModel();
            contentModel2To3To2List.Add(contentModel2To3To2To1);

            #endregion

            #region box_1_content_2_content_3_content_2_content2

            IconModel contentModel2To3To2To2 = new IconModel()
            {
                url = "https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip14.png"
            };
            contentModel2To3To2List.Add(contentModel2To3To2To2);

            #endregion

            #region box_1_content_2_content_3_content_2_content3

            TextModel contentModel2To3To2To3 = new TextModel()
            {
                text = "Add to cart",
                color = "#ffffff",
                flex = 0,
                offsetTop = "-2px"
            };
            contentModel2To3To2List.Add(contentModel2To3To2To3);

            #endregion

            #region box_1_content_2_content_3_content_2_content4

            FillerModel contentModel2To3To2To4 = new FillerModel();
            contentModel2To3To2List.Add(contentModel2To3To2To4);

            #endregion

            #endregion

            contentModel2To3To2.contents = contentModel2To3To2List;
            contentModel2To3List.Add(contentModel2To3To2);

            #region box_1_content_2_content_3_content_3

            FillerModel contentModel2To3To3 = new FillerModel();
            contentModel2To3List.Add(contentModel2To3To3);
            #endregion

            #endregion

            contentModel2To3.contents = contentModel2To3List;
            contentModel2List.Add(contentModel2To3);

            #endregion

            contentModel2.contents = contentModel2List;
            mainboxModelList.Add(contentModel2);

            #region box_1_content_3

            BoxModel contentModel3 = new BoxModel()
            {
                layout = FlexLayout.vertical,
                position = FlexPosition.absolute,
                cornerRadius = "20px",
                offsetTop = "18px",
                backgroundColor = "#ff334b",
                offsetStart = "18px",
                height = "25px",
                width = "52px"
            };
            List<FlexComponentModel> contentModel3List = new List<FlexComponentModel>();

            #region box_1_content_3_content1

            TextModel contentModel3To1 = new TextModel()
            {
                text = "SALE",
                color = "#ffffff",
                align = FlexAlign.center,
                size = FlexFontSize.xs,
                offsetTop = "3px"
            };
            contentModel3List.Add(contentModel3To1);

            #endregion

            #endregion

            contentModel3.contents = contentModel3List;
            mainboxModelList.Add(contentModel3);

            #endregion

            mainBoxModel.contents = mainboxModelList;

            #endregion

            bubbleModel.body = mainBoxModel;
            carouselContentList.Add(bubbleModel);

            #endregion

            carouselModel.contents = carouselContentList;

            return carouselModel;
        }

        public string Create2()
        {
            string result = @"[
  {
    ""type"": ""flex"",
    ""altText"": ""Apparel"",
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
                ""type"": ""image"",
                ""url"": ""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip1.jpg"",
                ""size"": ""full"",
                ""aspectMode"": ""cover"",
                ""aspectRatio"": ""2:3"",
                ""gravity"": ""top""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""box"",
                    ""layout"": ""vertical"",
                    ""contents"": [
                      {
                        ""type"": ""text"",
                        ""text"": ""Brown's T-shirts"",
                        ""size"": ""xl"",
                        ""color"": ""#ffffff"",
                        ""weight"": ""bold""
                      }
                    ]
                  },
                  {
                    ""type"": ""box"",
                    ""layout"": ""baseline"",
                    ""contents"": [
                      {
                        ""type"": ""text"",
                        ""text"": ""￥35,800"",
                        ""color"": ""#ebebeb"",
                        ""size"": ""sm"",
                        ""flex"": 0
                      },
                      {
                        ""type"": ""text"",
                        ""text"": ""￥75,000"",
                        ""color"": ""#ffffffcc"",
                        ""decoration"": ""line-through"",
                        ""gravity"": ""bottom"",
                        ""flex"": 0,
                        ""size"": ""sm""
                      }
                    ],
                    ""spacing"": ""lg""
                  },
                  {
                    ""type"": ""box"",
                    ""layout"": ""vertical"",
                    ""contents"": [
                      {
                        ""type"": ""filler""
                      },
                      {
                        ""type"": ""box"",
                        ""layout"": ""baseline"",
                        ""contents"": [
                          {
                            ""type"": ""filler""
                          },
                          {
                            ""type"": ""icon"",
                            ""url"": ""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip14.png""
                          },
                          {
                            ""type"": ""text"",
                            ""text"": ""Add to cart"",
                            ""color"": ""#ffffff"",
                            ""flex"": 0,
                            ""offsetTop"": ""-2px""
                          },
                          {
                            ""type"": ""filler""
                          }
                        ],
                        ""spacing"": ""sm""
                      },
                      {
                        ""type"": ""filler""
                      }
                    ],
                    ""borderWidth"": ""1px"",
                    ""cornerRadius"": ""4px"",
                    ""spacing"": ""sm"",
                    ""borderColor"": ""#ffffff"",
                    ""margin"": ""xxl"",
                    ""height"": ""40px""
                  }
                ],
                ""position"": ""absolute"",
                ""offsetBottom"": ""0px"",
                ""offsetStart"": ""0px"",
                ""offsetEnd"": ""0px"",
                ""backgroundColor"": ""#03303Acc"",
                ""paddingAll"": ""20px"",
                ""paddingTop"": ""18px""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""SALE"",
                    ""color"": ""#ffffff"",
                    ""align"": ""center"",
                    ""size"": ""xs"",
                    ""offsetTop"": ""3px""
                  }
                ],
                ""position"": ""absolute"",
                ""cornerRadius"": ""20px"",
                ""offsetTop"": ""18px"",
                ""backgroundColor"": ""#ff334b"",
                ""offsetStart"": ""18px"",
                ""height"": ""25px"",
                ""width"": ""53px""
              }
            ],
            ""paddingAll"": ""0px""
          }
        },
        {
          ""type"": ""bubble"",
          ""body"": {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""image"",
                ""url"": ""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip2.jpg"",
                ""size"": ""full"",
                ""aspectMode"": ""cover"",
                ""aspectRatio"": ""2:3"",
                ""gravity"": ""top""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""box"",
                    ""layout"": ""vertical"",
                    ""contents"": [
                      {
                        ""type"": ""text"",
                        ""text"": ""Cony's T-shirts"",
                        ""size"": ""xl"",
                        ""color"": ""#ffffff"",
                        ""weight"": ""bold""
                      }
                    ]
                  },
                  {
                    ""type"": ""box"",
                    ""layout"": ""baseline"",
                    ""contents"": [
                      {
                        ""type"": ""text"",
                        ""text"": ""￥35,800"",
                        ""color"": ""#ebebeb"",
                        ""size"": ""sm"",
                        ""flex"": 0
                      },
                      {
                        ""type"": ""text"",
                        ""text"": ""￥75,000"",
                        ""color"": ""#ffffffcc"",
                        ""decoration"": ""line-through"",
                        ""gravity"": ""bottom"",
                        ""flex"": 0,
                        ""size"": ""sm""
                      }
                    ],
                    ""spacing"": ""lg""
                  },
                  {
                    ""type"": ""box"",
                    ""layout"": ""vertical"",
                    ""contents"": [
                      {
                        ""type"": ""filler""
                      },
                      {
                        ""type"": ""box"",
                        ""layout"": ""baseline"",
                        ""contents"": [
                          {
                            ""type"": ""filler""
                          },
                          {
                            ""type"": ""icon"",
                            ""url"": ""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip14.png""
                          },
                          {
                            ""type"": ""text"",
                            ""text"": ""Add to cart"",
                            ""color"": ""#ffffff"",
                            ""flex"": 0,
                            ""offsetTop"": ""-2px""
                          },
                          {
                            ""type"": ""filler""
                          }
                        ],
                        ""spacing"": ""sm""
                      },
                      {
                        ""type"": ""filler""
                      }
                    ],
                    ""borderWidth"": ""1px"",
                    ""cornerRadius"": ""4px"",
                    ""spacing"": ""sm"",
                    ""borderColor"": ""#ffffff"",
                    ""margin"": ""xxl"",
                    ""height"": ""40px""
                  }
                ],
                ""position"": ""absolute"",
                ""offsetBottom"": ""0px"",
                ""offsetStart"": ""0px"",
                ""offsetEnd"": ""0px"",
                ""backgroundColor"": ""#9C8E7Ecc"",
                ""paddingAll"": ""20px"",
                ""paddingTop"": ""18px""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""SALE"",
                    ""color"": ""#ffffff"",
                    ""align"": ""center"",
                    ""size"": ""xs"",
                    ""offsetTop"": ""3px""
                  }
                ],
                ""position"": ""absolute"",
                ""cornerRadius"": ""20px"",
                ""offsetTop"": ""18px"",
                ""backgroundColor"": ""#ff334b"",
                ""offsetStart"": ""18px"",
                ""height"": ""25px"",
                ""width"": ""53px""
              }
            ],
            ""paddingAll"": ""0px""
          }
        }
      ]
    }
  }
]";

            return result;
        }

        public string Create3()
        {
            string result = @"[{""type"":""flex"",""altText"":""Apparel"",""contents"":{""type"":""carousel"",""contents"":[{""type"":""bubble"",""body"":{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""image"",""url"":""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip1.jpg"",""size"":""full"",""aspectMode"":""cover"",""aspectRatio"":""2:3"",""gravity"":""top""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""text"",""text"":""Brown's T-shirts"",""size"":""xl"",""color"":""#ffffff"",""weight"":""bold""}]},{""type"":""box"",""layout"":""baseline"",""contents"":[{""type"":""text"",""text"":""¥35,800"",""color"":""#ebebeb"",""size"":""sm"",""flex"":0},{""type"":""text"",""text"":""¥75,000"",""color"":""#ffffffcc"",""decoration"":""line-through"",""gravity"":""bottom"",""flex"":0,""size"":""sm""}],""spacing"":""lg""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""filler""},{""type"":""box"",""layout"":""baseline"",""contents"":[{""type"":""filler""},{""type"":""icon"",""url"":""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip14.png""},{""type"":""text"",""text"":""Add to cart"",""color"":""#ffffff"",""flex"":0,""offsetTop"":""-2px""},{""type"":""filler""}],""spacing"":""sm""},{""type"":""filler""}],""borderWidth"":""1px"",""cornerRadius"":""4px"",""spacing"":""sm"",""borderColor"":""#ffffff"",""margin"":""xxl"",""height"":""40px""}],""position"":""absolute"",""offsetBottom"":""0px"",""offsetStart"":""0px"",""offsetEnd"":""0px"",""backgroundColor"":""#03303Acc"",""paddingAll"":""20px"",""paddingTop"":""18px""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""text"",""text"":""SALE"",""color"":""#ffffff"",""align"":""center"",""size"":""xs"",""offsetTop"":""3px""}],""position"":""absolute"",""cornerRadius"":""20px"",""offsetTop"":""18px"",""backgroundColor"":""#ff334b"",""offsetStart"":""18px"",""height"":""25px"",""width"":""53px""}],""paddingAll"":""0px""}},{""type"":""bubble"",""body"":{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""image"",""url"":""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip2.jpg"",""size"":""full"",""aspectMode"":""cover"",""aspectRatio"":""2:3"",""gravity"":""top""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""text"",""text"":""Cony's T-shirts"",""size"":""xl"",""color"":""#ffffff"",""weight"":""bold""}]},{""type"":""box"",""layout"":""baseline"",""contents"":[{""type"":""text"",""text"":""¥35,800"",""color"":""#ebebeb"",""size"":""sm"",""flex"":0},{""type"":""text"",""text"":""¥75,000"",""color"":""#ffffffcc"",""decoration"":""line-through"",""gravity"":""bottom"",""flex"":0,""size"":""sm""}],""spacing"":""lg""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""filler""},{""type"":""box"",""layout"":""baseline"",""contents"":[{""type"":""filler""},{""type"":""icon"",""url"":""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip14.png""},{""type"":""text"",""text"":""Add to cart"",""color"":""#ffffff"",""flex"":0,""offsetTop"":""-2px""},{""type"":""filler""}],""spacing"":""sm""},{""type"":""filler""}],""borderWidth"":""1px"",""cornerRadius"":""4px"",""spacing"":""sm"",""borderColor"":""#ffffff"",""margin"":""xxl"",""height"":""40px""}],""position"":""absolute"",""offsetBottom"":""0px"",""offsetStart"":""0px"",""offsetEnd"":""0px"",""backgroundColor"":""#9C8E7Ecc"",""paddingAll"":""20px"",""paddingTop"":""18px""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""text"",""text"":""SALE"",""color"":""#ffffff"",""align"":""center"",""size"":""xs"",""offsetTop"":""3px""}],""position"":""absolute"",""cornerRadius"":""20px"",""offsetTop"":""18px"",""backgroundColor"":""#ff334b"",""offsetStart"":""18px"",""height"":""25px"",""width"":""53px""}],""paddingAll"":""0px""}}]}}]";

            return result;
        }
    }
}