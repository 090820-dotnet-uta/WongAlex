--SELECT * FROM Album;
--SELECT * FROM Artist;
--SELECT * FROM Customer;
--SELECT * FROM Employee;
--SELECT * FROM Genere;
--SELECT * FROM Invoice;
--SELECT * FROM InvoiceLine;
--SELECT * FROM MediaType;
--SELECT * FROM Playlist;
--SELECT * FROM PlaylistTrack;
--SELECT * FROM Track;

-- DML Activity

-- 1. List all customers (full names, customer ID, and country) who are not in the US
SELECT CustomerId, Country, FirstName + ' ' + LastName AS FullName 
FROM Customer
WHERE Country != 'USA';

-- 2. List all customers from brazil
SELECT * FROM Customer
WHERE Country = 'Brazil';

-- 3. List all sales agents
SELECT * FROM Employee
WHERE Title = 'Sales Support Agent';

-- 4. Show a list of all countries in billing addresses on invoices.
SELECT DISTINCT BillingCountry 
FROM Invoice;

-- 5. How many invoices were there in 2009, and what was the sales total for that year?
SELECT COUNT(InvoiceDate) AS InvoicesIn2009, SUM(Total) AS SalesTotal 
FROM Invoice
Where YEAR(InvoiceDate) = 2009;

-- 6. How many line items were there for invoice #37?
SELECT COUNT(InvoiceLineId) AS NumLineItems
FROM InvoiceLine
WHERE InvoiceId = 37;

-- 7. How many invoices per country?
SELECT BillingCountry, COUNT(InvoiceId) AS NumInvoices
FROM Invoice
GROUP BY BillingCountry;

-- 8. Show total sales per country, ordered by highest sales first.
SELECT BillingCountry, SUM(Total) AS TotalSales
FROM Invoice
GROUP BY BillingCountry
ORDER BY TotalSales DESC;