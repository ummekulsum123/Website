import network from './network';
import qs from 'qs';
import { API_URL } from './urls';

export const signIn = (login, password) => network.post(`${API_URL}?auth`, qs.stringify({ login, password }));

export const dataTable = (start, limit, ext_id_landfill_weight, dateTo, dateFrom, transport) =>
  network.post(`${API_URL}?landfills`, qs.stringify({ start, limit, ext_id_landfill_weight, dateTo, dateFrom, transport }));

export const userList = () => network.post(`${API_URL}?listUsers`, qs.stringify({}));

export const createUser = (login, password) => network.post(`${API_URL}?createUser`, qs.stringify({ login, password }));

export const deleteUser = (userId) => network.post(`${API_URL}?deleteUser`, qs.stringify({ userId }));

export const updateUser = (login, password, userId) =>
  network.post(`${API_URL}?updateUser`, qs.stringify({ login, password, userId }));

export const listLandfill = () => network.post(`${API_URL}?listLandfill`, qs.stringify({}));

export const listCar = (ext_id_landfill_weight) =>
  network.post(`${API_URL}?listCar`, qs.stringify({ ext_id_landfill_weight }));

export const graphCar = (dateTo, dateFrom, ext_id_landfill_weight, transport) =>
  network.post(`${API_URL}?graphCar`, qs.stringify({ dateTo, dateFrom, ext_id_landfill_weight, transport }));

export const graph = (dateTo, dateFrom, type) =>
  network.post(`${API_URL}?graph`, qs.stringify({ dateTo, dateFrom, type }));