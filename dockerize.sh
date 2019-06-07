#!/bin/bash
export VERSION=$(git tag --sort=-version:refname | head -1)
docker build --no-cache -f ./Source/Dockerfile -t dolittle/timeseries-identitymapper:$VERSION .
docker push dolittle/timeseries-identitymapper:$VERSION