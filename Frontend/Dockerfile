# build
FROM node:10.15.1 AS build
WORKDIR /usr/src/app
COPY Frontend ./
RUN ls
RUN npm i
ARG Environment=Production
ENV NODE_ENV=$Environment
RUN npm run build
# run
FROM nginx
ARG Environment=Production
RUN rm -f /etc/nginx/conf.d/default.conf
COPY Frontend/nginxconfigs/nginx.conf /etc/nginx/conf.d/
COPY --from=build /usr/src/app/build /usr/share/nginx/html
EXPOSE 80