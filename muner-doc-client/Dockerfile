FROM node:21.7.1-alpine3.18
WORKDIR /app
COPY . .
RUN npm run build
CMD [ "npm", "start" ]