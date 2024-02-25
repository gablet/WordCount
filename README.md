# WordCount

# To start project run following command in the Application directory
```bash
dotnet run
```

# Test the api by sending this request

curl -X 'POST' \
  'http://localhost:5100/word/frequency' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '"Dog Cat Rat Dog Monkey Lion Rat"'

# To run test run following command in the Test.Unit directory
```bash
dotnet test
```