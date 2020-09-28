import axios from 'axios';
import qs from 'qs';
import isObject from 'lodash/isObject';
import isString from 'lodash/isString';

const network = axios.create();

network.interceptors.request.use((configParam) => {
  const config = configParam;
  const apiKey = localStorage.getItem('apiKey');
  if (config.url !== 'http://api.posrednik-rf.com/api_kreo/ajax.php?auth') {
    if (!config.data) {
      if (apiKey) config.data = qs.stringify({ apiKey: apiKey });
      return config;
    }
    if (isObject(config.data)) {
      config.data = qs.stringify({ apiKey: apiKey, ...config.data });
      return config;
    }
    if (isString(config.data)) {
      const data = qs.parse(config.data);
      config.data = qs.stringify({ apiKey: apiKey, ...data });
      return config;
    }
  }
  return config;
});

network.interceptors.response.use(
  (response) => {
    const { error_code: errorCode } = response?.data;
    if (errorCode) {
      console.log('errorCode', errorCode);
    }
    return Promise.resolve(response);
  },
  (errorParam) => {
    const error = errorParam;
    const resp = error.response;
    console.log('respError', resp);

    return error;
  }
);

export default network;
