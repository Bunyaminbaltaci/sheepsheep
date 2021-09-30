using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class reklam : MonoBehaviour
{
    // Start is called before the first frame update
    private BannerView bannerView;
   
    
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
      
        RequestBanner();
       
        
    }

    private void RequestBanner()
    {
            
        string adUnitId = "ca-app-pub-4123278390459389/6545992476";
        this.bannerView = new BannerView(adUnitId,AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request );
    }   
    public void reklamkaldir()
    {
        bannerView.Destroy();


    }
}
