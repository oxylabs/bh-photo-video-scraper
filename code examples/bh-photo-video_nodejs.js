import fetch from 'node-fetch';

const username = 'YOUR_USERNAME';
const password = 'YOUR_PASSWORD';
const body = {
  'source': 'universal_ecommerce',
  'url': 'https://www.bhphotovideo.com/c/browse/photography/ci/989/n/4294538916?usource=lc&lc_aid=155352&gad_source=1&gclid=cjwkcaiaungubhakeiwagid4asfe6eo7ztftj_7yirnqc0yembejfvvhmjow87_7xwmaenz4vpjibboc_ysqavd_bwe',
};
const response = await fetch('https://realtime.oxylabs.io/v1/queries', {
  method: 'post',
  body: JSON.stringify(body),
  headers: {
    'Content-Type': 'application/json',
    'Authorization': 'Basic ' + Buffer.from(`${username}:${password}`).toString('base64'),
  }
});

console.log(await response.json());