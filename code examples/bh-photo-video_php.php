<?php

$params = [
    'source' => 'universal_ecommerce',
    'url' => 'https://www.bhphotovideo.com/c/browse/photography/ci/989/n/4294538916?usource=lc&lc_aid=155352&gad_source=1&gclid=cjwkcaiaungubhakeiwagid4asfe6eo7ztftj_7yirnqc0yembejfvvhmjow87_7xwmaenz4vpjibboc_ysqavd_bwe',
];

$ch = curl_init();

curl_setopt($ch, CURLOPT_URL, "https://realtime.oxylabs.io/v1/queries");
curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
curl_setopt($ch, CURLOPT_POSTFIELDS, json_encode($params));
curl_setopt($ch, CURLOPT_POST, 1);
curl_setopt($ch, CURLOPT_USERPWD, "user" . ":" . "pass1");

$headers = array();
$headers[] = "Content-Type: application/json";
curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);

$result = curl_exec($ch);
echo $result;

if (curl_errno($ch)) {
    echo 'Error:' . curl_error($ch);
}
curl_close ($ch);
?>