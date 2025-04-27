# Overview
This project demonstrates building a complete ASP.NET Core Web API for managing products with a simple frontend to consume the API. 
It also covers containerizing the API with Docker, pushing it to Docker Hub, and deploying it on Kubernetes with Minikube.

## Features
* List all products (GET /api/products)
* Get a single product by ID (GET /api/products/{id})
* Add a new product (POST /api/products)
* Configuration values for AppName and DefaultCurrency
* Frontend built with simple HTML/JavaScript
* Dockerized API
* Kubernetes deployment with manifests

## Prerequisites
* .NET 8
* Docker
* Kubernetes (Minikube)

## Docker Instructions
docker build -t productapi:v2 -f ProductAPI/Dockerfile .
docker run -d -p 5000:80 productapi:v1

## Kubernetes Deployment
* minikube start
* kubectl apply -f k8s/productapi-deployment.yaml
* kubectl apply -f k8s/productapi-service.yaml




