FROM node:18.13.0 as build
WORKDIR /app
COPY package*.json ./
RUN npm install
RUN npm install -g @angular/cli
COPY . .
FROM nginx:latest
COPY --from=build app/dist/myprofile/browser /usr/share/nginx/html
EXPOSE 80