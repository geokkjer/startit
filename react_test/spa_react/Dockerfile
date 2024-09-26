# frontend/Dockerfile
FROM node:22.9-alpine3.19 AS prod

WORKDIR /

COPY public/ /public
COPY src/ /src
COPY package.json /

RUN npm install

CMD ["npm", "start"]