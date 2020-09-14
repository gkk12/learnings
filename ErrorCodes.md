Error Codes:

1.Client Error Codes: Error codes from 400 to 499, which are the result of HTTP requests sent by a user client .
2.Server Error Codes: Error codes from 500 to 599, returned by a web server when it is aware that an error has occurred or is not able to process the request.

Client Error Codes:
  a)The 400 status code - HTTP request that was sent to the server has invalid syntax.

  b)401 Unauthorized error -User is trying to access the resource has not been authenticated. The user must provide credentials to be able to view the protected resource.

  c)403 Forbidden code – User has made a valid request but the server is refusing to serve the request, due to a lack of permission to access the requested resource. 
    Eg: File Permissions: 403 errors commonly occur when the user that is running the web server process does not have sufficient permissions to read the file that is 
    being accessed.
  d)404 Not Found Error - User is able to communicate with the server but it is unable to locate the requested file or resource.
    Eg: URL could have a typographical error in it , or could be a wrong URL, the resource might have been moved or deleted on the server, the user that owns the web
    server worker process might not have privileges to traverse to the directory that the requested file is in.

Server Error Codes:
  a)500 Internal Server Error, means that server cannot process the request for an unknown reason.
    Could be due to missing packages (e.g. trying to execute a PHP file without PHP installed properly).
  b)502 Bad Gateway - The server is a gateway or proxy server, and it is not receiving a valid response from the backend servers that should actually fulfill the request.
  c)503 Service Unavailable – server is overloaded or under maintenance. This error implies that the service should become available at some point.
  d)504 Gateway Timeout error, means that the server is a gateway or proxy server, and it is not receiving a response from the backend servers within the allowed time period.
    Eg: The network connection between the servers is poor, the backend server that is fulfilling the request is too slow, due to poor performance.



