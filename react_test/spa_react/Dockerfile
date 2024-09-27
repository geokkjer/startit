# frontend/Dockerfile
FROM node:22.9-alpine3.19 AS prod

WORKDIR /react_test/spa_react/

COPY public/ /public
COPY src/ /src
COPY package.json /

RUN npm install

CMD ["npm", "start"]