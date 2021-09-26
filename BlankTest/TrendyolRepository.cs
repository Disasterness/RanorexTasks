﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace BlankTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the TrendyolRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("f4a15ca4-011e-45b3-ad75-5804f1445ba2")]
    public partial class TrendyolRepository : RepoGenBaseFolder
    {
        static TrendyolRepository instance = new TrendyolRepository();
        TrendyolRepositoryFolders.EnTrendUEruenlerTuerkiyeninOnlineAlAppFolder _entrendueruenlertuerkiyeninonlineal;

        /// <summary>
        /// Gets the singleton class instance representing the TrendyolRepository element repository.
        /// </summary>
        [RepositoryFolder("f4a15ca4-011e-45b3-ad75-5804f1445ba2")]
        public static TrendyolRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public TrendyolRepository() 
            : base("TrendyolRepository", "/", null, 0, false, "f4a15ca4-011e-45b3-ad75-5804f1445ba2", ".\\RepositoryImages\\TrendyolRepositoryf4a15ca4.rximgres")
        {
            _entrendueruenlertuerkiyeninonlineal = new TrendyolRepositoryFolders.EnTrendUEruenlerTuerkiyeninOnlineAlAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f4a15ca4-011e-45b3-ad75-5804f1445ba2")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The EnTrendUEruenlerTuerkiyeninOnlineAl folder.
        /// </summary>
        [RepositoryFolder("fd8dad48-1889-49fe-a152-5fbae8930ec5")]
        public virtual TrendyolRepositoryFolders.EnTrendUEruenlerTuerkiyeninOnlineAlAppFolder EnTrendUEruenlerTuerkiyeninOnlineAl
        {
            get { return _entrendueruenlertuerkiyeninonlineal; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class TrendyolRepositoryFolders
    {
        /// <summary>
        /// The EnTrendUEruenlerTuerkiyeninOnlineAlAppFolder folder.
        /// </summary>
        [RepositoryFolder("fd8dad48-1889-49fe-a152-5fbae8930ec5")]
        public partial class EnTrendUEruenlerTuerkiyeninOnlineAlAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _girişyapInfo;
            RepoItemInfo _emailloginInfo;
            RepoItemInfo _passwordloginInfo;
            RepoItemInfo _loginbuttonInfo;
            RepoItemInfo _luetfengecerlibirepostaadresigirinInfo;
            RepoItemInfo _enterproductnameInfo;
            RepoItemInfo _searchproductInfo;
            RepoItemInfo _tshirtInfo;
            RepoItemInfo _addtocartInfo;
            RepoItemInfo _cartInfo;
            RepoItemInfo _cartitemInfo;
            RepoItemInfo _trendyolInfo;
            RepoItemInfo _fvrtbtnInfo;
            RepoItemInfo _favoritesInfo;
            RepoItemInfo _imgwrapperInfo;
            RepoItemInfo _secondproductInfo;
            RepoItemInfo _saveandcontinueInfo;
            RepoItemInfo _paymentInfo;
            RepoItemInfo _tshirt2Info;
            RepoItemInfo _approvecartInfo;
            RepoItemInfo _cıkışyapInfo;
            RepoItemInfo _myaccountInfo;
            RepoItemInfo _yardımdestekInfo;
            RepoItemInfo _questionInfo;

            /// <summary>
            /// Creates a new EnTrendUEruenlerTuerkiyeninOnlineAl  folder.
            /// </summary>
            public EnTrendUEruenlerTuerkiyeninOnlineAlAppFolder(RepoGenBaseFolder parentFolder) :
                    base("EnTrendUEruenlerTuerkiyeninOnlineAl", "/dom[@domain='www.trendyol.com']", parentFolder, 30000, null, false, "fd8dad48-1889-49fe-a152-5fbae8930ec5", "")
            {
                _girişyapInfo = new RepoItemInfo(this, "GirişYap", ".//div[#'account-navigation-container']/div/div[1]/?/?/p[@innertext='Giriş Yap']", ".//div[#'account-navigation-container']//p[@innertext='Giriş Yap']", 30000, null, "158b6fc5-6a1b-41ff-a041-19c32430b4d2");
                _emailloginInfo = new RepoItemInfo(this, "EmailLogin", ".//input[#'login-email']", ".//input[#'login-email']", 30000, null, "8b7d1a2e-475f-4819-8e4b-7e82f8ded8a9");
                _passwordloginInfo = new RepoItemInfo(this, "PasswordLogin", ".//input[#'login-password-input']", ".//input[#'login-password-input']", 30000, null, "ba5c1417-6191-40a3-8b33-fe106e472c6f");
                _loginbuttonInfo = new RepoItemInfo(this, "LoginButton", ".//div[#'login-register']//form[@action='https://www.trendyol.com/giris?cb=https%3A%2F%2Fwww.trendyol.com%2F']/button", ".//div[#'login-register']//form/button", 30000, null, "a7ceac7b-37a2-4678-9857-d1460f92fdb3");
                _luetfengecerlibirepostaadresigirinInfo = new RepoItemInfo(this, "LuetfenGecerliBirEPostaAdresiGirin", ".//div[#'error-box-wrapper']/span[@innertext>'Lütfen geçerli bir e-posta']", ".//div[#'error-box-wrapper']/span[@innertext>'Lütfen geçerli bir e-posta']", 30000, null, "c3474e51-2542-4872-b56b-0cd0be5ce14d");
                _enterproductnameInfo = new RepoItemInfo(this, "EnterProductName", ".//div[#'auto-complete-app']//input[@type='text']", ".//div[#'auto-complete-app']//input[@type='text']", 30000, null, "1f8a2085-b252-4836-8775-bb38e0a690fb");
                _searchproductInfo = new RepoItemInfo(this, "SearchProduct", ".//div[#'auto-complete-app']//i", ".//div[#'auto-complete-app']//i", 30000, null, "fc68de46-b1fb-4e56-8c36-ea439b2c7e83");
                _tshirtInfo = new RepoItemInfo(this, "Tshirt", ".//div[#'search-app']/div/div[1]/div[2]/div[2]/div/div[1]/?/?/a[@href>'https://www.trendyol.com/']/div[1]/div[2]/div[2]", ".//div[#'search-app']/div/div[1]/div[2]/div[2]/div/div[1]/div[1]/a[@href>'https://www.trendyol.com/']/div[1]/div[2]/div[2]", 30000, null, "cf4208d2-3f29-4f4e-be6e-45aafdf78374");
                _addtocartInfo = new RepoItemInfo(this, "AddToCart", ".//main[#'product-detail-app']/div/div[3]//button/div[@innertext='Sepete Ekle']", ".//main[#'product-detail-app']//div[@innertext='Sepete Ekle']", 30000, null, "1f3d55ed-f82c-4d6a-b516-99b543ebe5a4");
                _cartInfo = new RepoItemInfo(this, "Cart", ".//div[#'account-navigation-container']/div/div[2]/a[@href>'https://www.trendyol.com/']/p[@innertext='Sepetim']", ".//div[#'account-navigation-container']//p[@innertext='Sepetim']", 30000, null, "4d134731-d97b-48ee-b1d0-a0083c3042df");
                _cartitemInfo = new RepoItemInfo(this, "CartItem", ".//div[#'pb-container']/div/div[3]/div[2]", ".//div[#'pb-container']/div/div[3]/div[2]", 30000, null, "f11ad0b9-21fd-4520-a44d-c1f33e1ec2b8");
                _trendyolInfo = new RepoItemInfo(this, "Trendyol", ".//a[#'logo']/img[@alt='Trendyol']", ".//a[#'logo']/img[@alt='Trendyol']", 30000, null, "51feb4d2-acfe-46f3-b87e-27dc7e147d5f");
                _fvrtbtnInfo = new RepoItemInfo(this, "FvrtBtn", ".//div[#'search-app']/div/div[1]/div[2]/div[2]/div/div[5]/?/?/i", ".//div[#'search-app']/div/div[1]/div[2]/div[2]/div/div[5]/div[2]/i", 30000, null, "cab51549-7965-45ad-a398-baa4fdc0fa4c");
                _favoritesInfo = new RepoItemInfo(this, "Favorites", ".//div[#'account-navigation-container']/div/a[@href>'https://www.trendyol.com/']/?/?/p[@innertext='Favorilerim']", ".//div[#'account-navigation-container']//p[@innertext='Favorilerim']", 30000, null, "8547f76f-3f3a-4ae2-98dc-2f5c932ae1ed");
                _imgwrapperInfo = new RepoItemInfo(this, "ImgWrapper", ".//div[#'account-gw-favorites']/div/div[3]/div/div[1]/a[@href>'https://www.trendyol.com/']/div[1]", ".//div[#'account-gw-favorites']/div/div[3]/div/div[1]/a[@href>'https://www.trendyol.com/']/div[1]", 30000, null, "ddea020b-3309-4c5d-8d30-5f916c06bd15");
                _secondproductInfo = new RepoItemInfo(this, "SecondProduct", ".//main[#'product-detail-app']/div/aside[1]/div[2]/div/div/div/div[6]/?/?/a[@href>'https://www.trendyol.com/']/?/?/img[@src='https://cdn.dsmcdn.com/ty99/product/media/images/20210406/13/78188487/66369790/1/1_org_thumb.jpg']", ".//main[#'product-detail-app']//img[@src='https://cdn.dsmcdn.com/ty99/product/media/images/20210406/13/78188487/66369790/1/1_org_thumb.jpg']", 30000, null, "5e72d05e-0c8a-4511-a3b0-1b4767270f40");
                _saveandcontinueInfo = new RepoItemInfo(this, "SaveAndContinue", ".//aside[#'CheckoutAside']/section[5]/a[@innertext='Kaydet ve Devam Et']", ".//aside[#'CheckoutAside']/section[5]/a[@innertext='Kaydet ve Devam Et']", 30000, null, "f12f63bf-76d4-4ee0-94bd-32fac35eddd4");
                _paymentInfo = new RepoItemInfo(this, "Payment", ".//aside[#'CheckoutAside']/section[6]/a[@innertext='Ödeme Yap']", ".//aside[#'CheckoutAside']/section[6]/a[@innertext='Ödeme Yap']", 30000, null, "70141e78-4c4d-421a-8023-ec4e091c77e8");
                _tshirt2Info = new RepoItemInfo(this, "Tshirt2", ".//div[#'search-app']/div/div[1]/div[2]/div[2]/div/div[2]/?/?/a[@href>'https://www.trendyol.com/']/div[1]/div[2]/div[2]", ".//div[#'search-app']/div/div[1]/div[2]/div[2]/div/div[2]/div[1]/a[@href>'https://www.trendyol.com/']/div[1]/div[2]/div[2]", 30000, null, "3c5ceb30-993d-4dfc-8238-7e017fe98a1f");
                _approvecartInfo = new RepoItemInfo(this, "ApproveCart", ".//div[#'pb-container']/aside/div/div[1]/a[@href>'https://www.trendyol.com/']", ".//div[#'pb-container']/aside/div/div[1]/a[@href>'https://www.trendyol.com/']", 30000, null, "7d01d482-4c90-4c86-967f-dcf716660d2c");
                _cıkışyapInfo = new RepoItemInfo(this, "CıkışYap", ".//div[#'account-navigation-container']/div/div[1]/div[2]/div/a[8]/p[@innertext='Çıkış Yap']", ".//div[#'account-navigation-container']//p[@innertext='Çıkış Yap']", 30000, null, "515fa48f-9fc7-42dd-bf5c-dc195bab46ba");
                _myaccountInfo = new RepoItemInfo(this, "MyAccount", ".//div[#'account-navigation-container']/div/div[1]/?/?/p[@innertext='Hesabım']", ".//div[#'account-navigation-container']//p[@innertext='Hesabım']", 30000, null, "d368e1ce-d0b2-4c71-861e-d95f2d304002");
                _yardımdestekInfo = new RepoItemInfo(this, "YardımDestek", ".//div[#'headerMain']//ul/?/?/a[@innertext='Yardım & Destek']", ".//div[#'headerMain']//a[@innertext='Yardım & Destek']", 30000, null, "3d5ac442-8d53-4a7c-86ca-1127d73e66b4");
                _questionInfo = new RepoItemInfo(this, "Question", ".//div[#'accordion']/div[1]", ".//div[#'accordion']/div[1]", 30000, null, "daac30c6-8efa-406b-814e-582c0c3085a0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("fd8dad48-1889-49fe-a152-5fbae8930ec5")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("fd8dad48-1889-49fe-a152-5fbae8930ec5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The GirişYap item.
            /// </summary>
            [RepositoryItem("158b6fc5-6a1b-41ff-a041-19c32430b4d2")]
            public virtual Ranorex.PTag GirişYap
            {
                get
                {
                    return _girişyapInfo.CreateAdapter<Ranorex.PTag>(true);
                }
            }

            /// <summary>
            /// The GirişYap item info.
            /// </summary>
            [RepositoryItemInfo("158b6fc5-6a1b-41ff-a041-19c32430b4d2")]
            public virtual RepoItemInfo GirişYapInfo
            {
                get
                {
                    return _girişyapInfo;
                }
            }

            /// <summary>
            /// The EmailLogin item.
            /// </summary>
            [RepositoryItem("8b7d1a2e-475f-4819-8e4b-7e82f8ded8a9")]
            public virtual Ranorex.InputTag EmailLogin
            {
                get
                {
                    return _emailloginInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The EmailLogin item info.
            /// </summary>
            [RepositoryItemInfo("8b7d1a2e-475f-4819-8e4b-7e82f8ded8a9")]
            public virtual RepoItemInfo EmailLoginInfo
            {
                get
                {
                    return _emailloginInfo;
                }
            }

            /// <summary>
            /// The PasswordLogin item.
            /// </summary>
            [RepositoryItem("ba5c1417-6191-40a3-8b33-fe106e472c6f")]
            public virtual Ranorex.InputTag PasswordLogin
            {
                get
                {
                    return _passwordloginInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The PasswordLogin item info.
            /// </summary>
            [RepositoryItemInfo("ba5c1417-6191-40a3-8b33-fe106e472c6f")]
            public virtual RepoItemInfo PasswordLoginInfo
            {
                get
                {
                    return _passwordloginInfo;
                }
            }

            /// <summary>
            /// The LoginButton item.
            /// </summary>
            [RepositoryItem("a7ceac7b-37a2-4678-9857-d1460f92fdb3")]
            public virtual Ranorex.ButtonTag LoginButton
            {
                get
                {
                    return _loginbuttonInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The LoginButton item info.
            /// </summary>
            [RepositoryItemInfo("a7ceac7b-37a2-4678-9857-d1460f92fdb3")]
            public virtual RepoItemInfo LoginButtonInfo
            {
                get
                {
                    return _loginbuttonInfo;
                }
            }

            /// <summary>
            /// The LuetfenGecerliBirEPostaAdresiGirin item.
            /// </summary>
            [RepositoryItem("c3474e51-2542-4872-b56b-0cd0be5ce14d")]
            public virtual Ranorex.SpanTag LuetfenGecerliBirEPostaAdresiGirin
            {
                get
                {
                    return _luetfengecerlibirepostaadresigirinInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The LuetfenGecerliBirEPostaAdresiGirin item info.
            /// </summary>
            [RepositoryItemInfo("c3474e51-2542-4872-b56b-0cd0be5ce14d")]
            public virtual RepoItemInfo LuetfenGecerliBirEPostaAdresiGirinInfo
            {
                get
                {
                    return _luetfengecerlibirepostaadresigirinInfo;
                }
            }

            /// <summary>
            /// The EnterProductName item.
            /// </summary>
            [RepositoryItem("1f8a2085-b252-4836-8775-bb38e0a690fb")]
            public virtual Ranorex.InputTag EnterProductName
            {
                get
                {
                    return _enterproductnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The EnterProductName item info.
            /// </summary>
            [RepositoryItemInfo("1f8a2085-b252-4836-8775-bb38e0a690fb")]
            public virtual RepoItemInfo EnterProductNameInfo
            {
                get
                {
                    return _enterproductnameInfo;
                }
            }

            /// <summary>
            /// The SearchProduct item.
            /// </summary>
            [RepositoryItem("fc68de46-b1fb-4e56-8c36-ea439b2c7e83")]
            public virtual Ranorex.ITag SearchProduct
            {
                get
                {
                    return _searchproductInfo.CreateAdapter<Ranorex.ITag>(true);
                }
            }

            /// <summary>
            /// The SearchProduct item info.
            /// </summary>
            [RepositoryItemInfo("fc68de46-b1fb-4e56-8c36-ea439b2c7e83")]
            public virtual RepoItemInfo SearchProductInfo
            {
                get
                {
                    return _searchproductInfo;
                }
            }

            /// <summary>
            /// The Tshirt item.
            /// </summary>
            [RepositoryItem("cf4208d2-3f29-4f4e-be6e-45aafdf78374")]
            public virtual Ranorex.DivTag Tshirt
            {
                get
                {
                    return _tshirtInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Tshirt item info.
            /// </summary>
            [RepositoryItemInfo("cf4208d2-3f29-4f4e-be6e-45aafdf78374")]
            public virtual RepoItemInfo TshirtInfo
            {
                get
                {
                    return _tshirtInfo;
                }
            }

            /// <summary>
            /// The AddToCart item.
            /// </summary>
            [RepositoryItem("1f3d55ed-f82c-4d6a-b516-99b543ebe5a4")]
            public virtual Ranorex.DivTag AddToCart
            {
                get
                {
                    return _addtocartInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The AddToCart item info.
            /// </summary>
            [RepositoryItemInfo("1f3d55ed-f82c-4d6a-b516-99b543ebe5a4")]
            public virtual RepoItemInfo AddToCartInfo
            {
                get
                {
                    return _addtocartInfo;
                }
            }

            /// <summary>
            /// The Cart item.
            /// </summary>
            [RepositoryItem("4d134731-d97b-48ee-b1d0-a0083c3042df")]
            public virtual Ranorex.PTag Cart
            {
                get
                {
                    return _cartInfo.CreateAdapter<Ranorex.PTag>(true);
                }
            }

            /// <summary>
            /// The Cart item info.
            /// </summary>
            [RepositoryItemInfo("4d134731-d97b-48ee-b1d0-a0083c3042df")]
            public virtual RepoItemInfo CartInfo
            {
                get
                {
                    return _cartInfo;
                }
            }

            /// <summary>
            /// The CartItem item.
            /// </summary>
            [RepositoryItem("f11ad0b9-21fd-4520-a44d-c1f33e1ec2b8")]
            public virtual Ranorex.DivTag CartItem
            {
                get
                {
                    return _cartitemInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The CartItem item info.
            /// </summary>
            [RepositoryItemInfo("f11ad0b9-21fd-4520-a44d-c1f33e1ec2b8")]
            public virtual RepoItemInfo CartItemInfo
            {
                get
                {
                    return _cartitemInfo;
                }
            }

            /// <summary>
            /// The Trendyol item.
            /// </summary>
            [RepositoryItem("51feb4d2-acfe-46f3-b87e-27dc7e147d5f")]
            public virtual Ranorex.ImgTag Trendyol
            {
                get
                {
                    return _trendyolInfo.CreateAdapter<Ranorex.ImgTag>(true);
                }
            }

            /// <summary>
            /// The Trendyol item info.
            /// </summary>
            [RepositoryItemInfo("51feb4d2-acfe-46f3-b87e-27dc7e147d5f")]
            public virtual RepoItemInfo TrendyolInfo
            {
                get
                {
                    return _trendyolInfo;
                }
            }

            /// <summary>
            /// The FvrtBtn item.
            /// </summary>
            [RepositoryItem("cab51549-7965-45ad-a398-baa4fdc0fa4c")]
            public virtual Ranorex.ITag FvrtBtn
            {
                get
                {
                    return _fvrtbtnInfo.CreateAdapter<Ranorex.ITag>(true);
                }
            }

            /// <summary>
            /// The FvrtBtn item info.
            /// </summary>
            [RepositoryItemInfo("cab51549-7965-45ad-a398-baa4fdc0fa4c")]
            public virtual RepoItemInfo FvrtBtnInfo
            {
                get
                {
                    return _fvrtbtnInfo;
                }
            }

            /// <summary>
            /// The Favorites item.
            /// </summary>
            [RepositoryItem("8547f76f-3f3a-4ae2-98dc-2f5c932ae1ed")]
            public virtual Ranorex.PTag Favorites
            {
                get
                {
                    return _favoritesInfo.CreateAdapter<Ranorex.PTag>(true);
                }
            }

            /// <summary>
            /// The Favorites item info.
            /// </summary>
            [RepositoryItemInfo("8547f76f-3f3a-4ae2-98dc-2f5c932ae1ed")]
            public virtual RepoItemInfo FavoritesInfo
            {
                get
                {
                    return _favoritesInfo;
                }
            }

            /// <summary>
            /// The ImgWrapper item.
            /// </summary>
            [RepositoryItem("ddea020b-3309-4c5d-8d30-5f916c06bd15")]
            public virtual Ranorex.DivTag ImgWrapper
            {
                get
                {
                    return _imgwrapperInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The ImgWrapper item info.
            /// </summary>
            [RepositoryItemInfo("ddea020b-3309-4c5d-8d30-5f916c06bd15")]
            public virtual RepoItemInfo ImgWrapperInfo
            {
                get
                {
                    return _imgwrapperInfo;
                }
            }

            /// <summary>
            /// The SecondProduct item.
            /// </summary>
            [RepositoryItem("5e72d05e-0c8a-4511-a3b0-1b4767270f40")]
            public virtual Ranorex.ImgTag SecondProduct
            {
                get
                {
                    return _secondproductInfo.CreateAdapter<Ranorex.ImgTag>(true);
                }
            }

            /// <summary>
            /// The SecondProduct item info.
            /// </summary>
            [RepositoryItemInfo("5e72d05e-0c8a-4511-a3b0-1b4767270f40")]
            public virtual RepoItemInfo SecondProductInfo
            {
                get
                {
                    return _secondproductInfo;
                }
            }

            /// <summary>
            /// The SaveAndContinue item.
            /// </summary>
            [RepositoryItem("f12f63bf-76d4-4ee0-94bd-32fac35eddd4")]
            public virtual Ranorex.ATag SaveAndContinue
            {
                get
                {
                    return _saveandcontinueInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The SaveAndContinue item info.
            /// </summary>
            [RepositoryItemInfo("f12f63bf-76d4-4ee0-94bd-32fac35eddd4")]
            public virtual RepoItemInfo SaveAndContinueInfo
            {
                get
                {
                    return _saveandcontinueInfo;
                }
            }

            /// <summary>
            /// The Payment item.
            /// </summary>
            [RepositoryItem("70141e78-4c4d-421a-8023-ec4e091c77e8")]
            public virtual Ranorex.ATag Payment
            {
                get
                {
                    return _paymentInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Payment item info.
            /// </summary>
            [RepositoryItemInfo("70141e78-4c4d-421a-8023-ec4e091c77e8")]
            public virtual RepoItemInfo PaymentInfo
            {
                get
                {
                    return _paymentInfo;
                }
            }

            /// <summary>
            /// The Tshirt2 item.
            /// </summary>
            [RepositoryItem("3c5ceb30-993d-4dfc-8238-7e017fe98a1f")]
            public virtual Ranorex.DivTag Tshirt2
            {
                get
                {
                    return _tshirt2Info.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Tshirt2 item info.
            /// </summary>
            [RepositoryItemInfo("3c5ceb30-993d-4dfc-8238-7e017fe98a1f")]
            public virtual RepoItemInfo Tshirt2Info
            {
                get
                {
                    return _tshirt2Info;
                }
            }

            /// <summary>
            /// The ApproveCart item.
            /// </summary>
            [RepositoryItem("7d01d482-4c90-4c86-967f-dcf716660d2c")]
            public virtual Ranorex.ATag ApproveCart
            {
                get
                {
                    return _approvecartInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ApproveCart item info.
            /// </summary>
            [RepositoryItemInfo("7d01d482-4c90-4c86-967f-dcf716660d2c")]
            public virtual RepoItemInfo ApproveCartInfo
            {
                get
                {
                    return _approvecartInfo;
                }
            }

            /// <summary>
            /// The CıkışYap item.
            /// </summary>
            [RepositoryItem("515fa48f-9fc7-42dd-bf5c-dc195bab46ba")]
            public virtual Ranorex.PTag CıkışYap
            {
                get
                {
                    return _cıkışyapInfo.CreateAdapter<Ranorex.PTag>(true);
                }
            }

            /// <summary>
            /// The CıkışYap item info.
            /// </summary>
            [RepositoryItemInfo("515fa48f-9fc7-42dd-bf5c-dc195bab46ba")]
            public virtual RepoItemInfo CıkışYapInfo
            {
                get
                {
                    return _cıkışyapInfo;
                }
            }

            /// <summary>
            /// The MyAccount item.
            /// </summary>
            [RepositoryItem("d368e1ce-d0b2-4c71-861e-d95f2d304002")]
            public virtual Ranorex.PTag MyAccount
            {
                get
                {
                    return _myaccountInfo.CreateAdapter<Ranorex.PTag>(true);
                }
            }

            /// <summary>
            /// The MyAccount item info.
            /// </summary>
            [RepositoryItemInfo("d368e1ce-d0b2-4c71-861e-d95f2d304002")]
            public virtual RepoItemInfo MyAccountInfo
            {
                get
                {
                    return _myaccountInfo;
                }
            }

            /// <summary>
            /// The YardımDestek item.
            /// </summary>
            [RepositoryItem("3d5ac442-8d53-4a7c-86ca-1127d73e66b4")]
            public virtual Ranorex.ATag YardımDestek
            {
                get
                {
                    return _yardımdestekInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The YardımDestek item info.
            /// </summary>
            [RepositoryItemInfo("3d5ac442-8d53-4a7c-86ca-1127d73e66b4")]
            public virtual RepoItemInfo YardımDestekInfo
            {
                get
                {
                    return _yardımdestekInfo;
                }
            }

            /// <summary>
            /// The Question item.
            /// </summary>
            [RepositoryItem("daac30c6-8efa-406b-814e-582c0c3085a0")]
            public virtual Ranorex.DivTag Question
            {
                get
                {
                    return _questionInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Question item info.
            /// </summary>
            [RepositoryItemInfo("daac30c6-8efa-406b-814e-582c0c3085a0")]
            public virtual RepoItemInfo QuestionInfo
            {
                get
                {
                    return _questionInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
