# Task Manager
This project is for managing tasks, allowing you to manage your agenda efficiently. The project consists of two main parts: `news` for the application and `WebApi` for the server.

## Table of Contents
- [Purpose](#purpose)
- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [Dependencies](#dependencies)
- [Architecture](#architecture)
- [Contributing](#contributing)
- [Reporting Issues](#reporting-issues)
- [License](#license)

## Purpose

The purpose of this application is to help users manage their daily tasks efficiently. Users can add, edit, and delete tasks, view tasks in a calendar format, and change their passwords for better data protection.

## Installation

Follow these steps to install and run your Expo project:

1. Extract the zip file to your desired location.
2. Navigate to the `webApi` directory:
    ```sh
    cd path/to/extracted/folder/webApi
    ```
3. Install dependencies:
    ```sh
    npm install
    ```
4. Start the project:
    ```sh
    npm run dev
    ```
5. Navigate to the `news` directory:
    ```sh
    cd ../news
    ```
6. Install `npx` if not already installed:
    ```sh
    npm install -g npx
    ```
7. Start the Expo project:
    ```sh
    npx expo start
    ```

## Usage

Briefly describe how to use project
1. Open the Expo client.
2. Scan the QR code.
3. Start using the app.

## Features

- Record daily tasks with basic add, edit, and delete functionality, presented in a list.
- View tasks for a selected day in a calendar format, where clicking on a specific day shows the task list for that day.
- Change user passwords to better protect user data.
- 

## Dependencies

List of dependencies and how to install them:
- [Node.js](https://nodejs.org/en/download/) - Ensure Node.js is installed.
- [npx](https://www.npmjs.com/package/npx) - Install globally using:
  ```sh
  npm install -g npx

## Architecture
The application is divided into two main parts:

WebApi: This is the server side of the application that handles API requests and data storage.
News: This is the client side of the application built using Expo, where users can interact with the task manager.


## Contributing

Contributions are welcome! Please refer to the [Contributing Guidelines](CONTRIBUTING.md) for more information.

## License
This project uses several open source libraries. For a complete list of these libraries and their licenses, please refer to the [licenses.json](../news/licenses.json) file.

## Reporting Issues
If you encounter any issues, please open a GitHub issue and provide detailed information to help us resolve the problem.