# Bh-Photo-Video Scraper API

[![Oxylabs promo code](https://user-images.githubusercontent.com/129506779/250792357-8289e25e-9c36-4dc0-a5e2-2706db797bb5.png)](https://oxylabs.go2cloud.org/aff_c?offer_id=7&aff_id=877&url_id=112)

Oxylabs' [Bh-Photo-Video Scraper](https://oxylabs.io/products/scraper-api/ecommerce/bh-photo-video?utm_source=github&utm_medium=repositories&utm_campaign=product) is a data gathering solution allowing you to extract real-time information from an Bh-Photo-Video website effortlessly. This brief guide showcases how Bh-Photo-Video Scraper works, along with code examples to help you better understand how to use it hassle-free.

### How it works

You can get Bh-Photo-Video results by providing your own URLs to our service. We can return the HTML for any page you like.

#### Python code example

The example below illustrates how you can get HTML of Bh-Photo-Video page.

```python
import requests
from pprint import pprint

# Structure payload.
payload = {
    'source': 'universal_ecommerce',
    'url': 'https://www.bhphotovideo.com/c/browse/photography/ci/989/n/4294538916?usource=lc&lc_aid=155352&gad_source=1&gclid=cjwkcaiaungubhakeiwagid4asfe6eo7ztftj_7yirnqc0yembejfvvhmjow87_7xwmaenz4vpjibboc_ysqavd_bwe'
}

# Get response.
response = requests.request(
    'POST',
    'https://realtime.oxylabs.io/v1/queries',
    auth=('user', 'pass1'),
    json=payload,
)

# Instead of response with job status and results url, this will return the
# JSON response with the result.
pprint(response.json())
```
Find code examples for other programming languages [**here**](https://github.com/oxylabs/bh-photo-video-scraper/tree/main/code%20examples)

#### Output Example
```json
{
  "results": [
    {
      "content": "<!doctype html> <html lang=\"en\"><head><base data-rh=\"true\" href=\"/\" /><title data-rh=\"true\">Photogra ... </html>",
      "created_at": "2024-02-20 12:49:15",
      "updated_at": "2024-02-20 12:49:16",
      "page": 1,
      "url": "https://www.bhphotovideo.com/c/browse/photography/ci/989/n/4294538916?usource=lc&lc_aid=155352&gad_source=1&gclid=cjwkcaiaungubhakeiwagid4asfe6eo7ztftj_7yirnqc0yembejfvvhmjow87_7xwmaenz4vpjibboc_ysqavd_bwe",
      "job_id": "7165688855654329345",
      "status_code": 200
    }
  ]
}
```
With our Bh-Photo-Video Scraper, you can easily pull public data from any Bh-Photo-Video web page. Gather essential product details, such as specifications, user reviews, or product images, to understand the photography market better and maintain a competitive edge. Should you have any queries, our support team is just a live chat or an email (hello@oxylabs.io) away.