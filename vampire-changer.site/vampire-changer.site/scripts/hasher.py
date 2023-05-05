import sys
from passlib.hash import django_pbkdf2_sha256
secret = sys.argv[1]
hashed = sys.argv[2]
print(django_pbkdf2_sha256.verify(secret,hashed))
